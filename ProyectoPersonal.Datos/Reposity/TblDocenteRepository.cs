using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblDocenteRepository : ITblDocenteRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblDocenteRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblDocente docente)
        {
            IEnumerable<int> docenteResult = await _database.GetData<int>("fn_tbldocente_actualizar", new
            {
                p_lDocente_id = docente.lDocente_id,
                p_sDocente_codigo = docente.sDocente_codigo,
                p_sDocente_correo_docente = docente.sDocente_correo_docente,
                p_lPersona_id = docente.lPersona_id
            });
        }

        public async Task Crear(TblDocente docente)
        {
            IEnumerable<int> docenteResult = await _database.GetData<int>("fn_tbldocente_crear", new
            {
                p_sDocente_codigo = docente.sDocente_codigo,
                p_sDocente_correo_docente = docente.sDocente_correo_docente,
                p_lPersona_id = docente.lPersona_id
            });
        }

        public async Task Eliminar(int idDocente)
        {
            IEnumerable<int> docenteResult = await _database.GetData<int>("fn_tbldocente_eliminar", new
            {
                p_lDocente_id = idDocente
            });
        }

        public async Task<TblDocente> ObtenerPorId(int idDocente)
        {
            IEnumerable<TblDocente> docenteResult = await _database.GetData<TblDocente>("fn_tbldocente_obtenerporid", new
            {
                p_lDocente_id = idDocente
            });
            return docenteResult.FirstOrDefault();
        }

        public async Task<List<TblDocente>> ObtenerTodos()
        {
            IEnumerable<TblDocente> docenteResult = await _database.GetData<TblDocente>("fn_tbldocente_obtenertodos");
            return docenteResult.ToList();
        }
    }
}
