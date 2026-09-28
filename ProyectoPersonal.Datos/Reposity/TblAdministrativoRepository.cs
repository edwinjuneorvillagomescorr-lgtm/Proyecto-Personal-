using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblAdministrativoRepository : ITblAdministrativoRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblAdministrativoRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblAdministrativo administrativo)
        {
            IEnumerable<int> administrativoResult = await _database.GetData<int>("fn_tbladministrativo_actualizar", new
            {
                p_lAdministrativo_id = administrativo.lAdministrativo_id,
                p_sAdministrativo_nm = administrativo.sAdministrativo_nm,
                p_lPersona_id = administrativo.lPersona_id
            });
        }

        public async Task Crear(TblAdministrativo administrativo)
        {
            IEnumerable<int> administrativoResult = await _database.GetData<int>("fn_tbladministrativo_crear", new
            {
                p_sAdministrativo_nm = administrativo.sAdministrativo_nm,
                p_lPersona_id = administrativo.lPersona_id
            });
        }

        public async Task Eliminar(int idAdministrativo)
        {
            IEnumerable<int> administrativoResult = await _database.GetData<int>("fn_tbladministrativo_eliminar", new
            {
                p_lAdministrativo_id = idAdministrativo
            });
        }

        public async Task<TblAdministrativo> ObtenerPorId(int idAdministrativo)
        {
            IEnumerable<TblAdministrativo> administrativoResult = await _database.GetData<TblAdministrativo>("fn_tbladministrativo_obtenerporid", new
            {
                p_lAdministrativo_id = idAdministrativo
            });
            return administrativoResult.FirstOrDefault();
        }

        public async Task<List<TblAdministrativo>> ObtenerTodos()
        {
            IEnumerable<TblAdministrativo> administrativoResult = await _database.GetData<TblAdministrativo>("fn_tbladministrativo_obtenertodos");
            return administrativoResult.ToList();
        }
    }
}
