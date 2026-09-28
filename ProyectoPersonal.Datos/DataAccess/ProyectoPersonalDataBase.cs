using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace ProyectoPersonal.Datos.DataAccess
{
    public class ProyectoPersonalDataBase
    {
        private readonly IConfiguration _configuration;
        private readonly string connection = "DefaultConnection";

        public ProyectoPersonalDataBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<T>> GetData<T>(string functionName, object? parameters = null)
        {
            using IDbConnection conn = new NpgsqlConnection(_configuration.GetConnectionString(connection));
            try
            {
                string sql;

                if (parameters == null)
                {
                    sql = $"SELECT * FROM {functionName}()";
                }
                else
                {
                    var properties = parameters.GetType().GetProperties();
                    var paramNames = string.Join(", ", properties.Select(p => $"@{p.Name}"));
                    sql = $"SELECT * FROM {functionName}({paramNames})";
                }

                var result = await conn.QueryAsync<T>(sql, parameters, commandType: CommandType.Text);
                return result;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception($"Error al ejecutar la función {functionName}: {ex.ErrorCode}", ex);
            }
        }
    }
}