using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Interfaces
{
    public interface ITblDocenteRepository
    {
        public Task Crear(TblDocente docente);
        public Task<TblDocente> ObtenerPorId(int idDocente);
        public Task<List<TblDocente>> ObtenerTodos();
        public Task Actualizar(TblDocente docente);
        public Task Eliminar(int idDocente);
    }
}
