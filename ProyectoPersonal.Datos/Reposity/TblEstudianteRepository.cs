using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblEstudianteRepository : ITblEstudianteRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblEstudianteRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblEstudiante estudiante)
        {
            IEnumerable<int> estudianteResult = await _database.GetData<int>("fn_tblestudiante_actualizar", new
            {
                p_lEstudiante_id = estudiante.lEstudiante_id,
                p_sEstudiante_Carrera = estudiante.sEstudiante_Carrera,
                p_sEstudiante_Registro = estudiante.sEstudiante_Registro,
                p_lPersona_id = estudiante.lPersona_id
            });
        }

        public async Task Crear(TblEstudiante estudiante)
        {
            IEnumerable<int> estudianteResult = await _database.GetData<int>("fn_tblestudiante_crear", new
            {
                p_sEstudiante_Carrera = estudiante.sEstudiante_Carrera,
                p_sEstudiante_Registro = estudiante.sEstudiante_Registro,
                p_lPersona_id = estudiante.lPersona_id
            });
        }

        public async Task Eliminar(int idEstudiante)
        {
            IEnumerable<int> estudianteResult = await _database.GetData<int>("fn_tblestudiante_eliminar", new
            {
                p_lEstudiante_id = idEstudiante
            });
        }

        public async Task<TblEstudiante> ObtenerPorId(int idEstudiante)
        {
            IEnumerable<TblEstudiante> estudianteResult = await _database.GetData<TblEstudiante>("fn_tblestudiante_obtenerporid", new
            {
                p_lEstudiante_id = idEstudiante
            });
            return estudianteResult.FirstOrDefault();
        }

        public async Task<List<TblEstudiante>> ObtenerTodos()
        {
            IEnumerable<TblEstudiante> estudianteResult = await _database.GetData<TblEstudiante>("fn_tblestudiante_obtenertodos");
            return estudianteResult.ToList();
        }
    }
}
