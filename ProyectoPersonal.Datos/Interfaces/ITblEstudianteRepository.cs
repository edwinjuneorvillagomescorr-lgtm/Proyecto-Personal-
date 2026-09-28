using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Interfaces
{
    public interface ITblEstudianteRepository
    {
        public Task Crear(TblEstudiante estudiante);
        public Task<TblEstudiante> ObtenerPorId(int idEstudiante);
        public Task<List<TblEstudiante>> ObtenerTodos();
        public Task Actualizar(TblEstudiante estudiante);
        public Task Eliminar(int idEstudiante);
    }
}
