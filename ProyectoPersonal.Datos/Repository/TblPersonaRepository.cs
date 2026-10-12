using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblPersonaRepository : ITblPersonaRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblPersonaRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblPersona persona)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("fn_tblpersona_actualizar", new
            {
                p_lPersona_id = persona.lPersona_id,
                p_sPersona_nm = persona.sPersona_nm,
                p_sPersona_apellido = persona.sPersona_apellido,
                p_sPersona_correo = persona.sPersona_correo,
                p_sPersona_CI = persona.sPersona_CI
            });
        }

        public async Task Crear(TblPersona persona)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("fn_tblpersona_crear", new
            {
                p_sPersona_nm = persona.sPersona_nm,
                p_sPersona_apellido = persona.sPersona_apellido,
                p_sPersona_correo = persona.sPersona_correo,
                p_sPersona_CI = persona.sPersona_CI
            });
        }

        public async Task Eliminar(int idPersona)
        {
            IEnumerable<int> personaResult = await _database.GetData<int>("fn_tblpersona_eliminar", new
            {
                p_lPersona_id = idPersona
            });
        }

        public async Task<TblPersona> ObtenerPorId(int idPersona)
        {
            IEnumerable<TblPersona> personaResult = await _database.GetData<TblPersona>("fn_tblpersona_obtenerporid", new
            {
                p_lPersona_id = idPersona
            });
            return personaResult.FirstOrDefault();
        }

        public async Task<List<TblPersona>> ObtenerTodos()
        {
            IEnumerable<TblPersona> personaResult = await _database.GetData<TblPersona>("fn_tblpersona_obtenertodos");
            return personaResult.ToList();
        }
    }
}
