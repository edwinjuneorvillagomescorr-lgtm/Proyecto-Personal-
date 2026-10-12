using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblActivoRepository
    {
        public Task Crear(TblActivo activo);
        public Task<TblActivo> ObtenerPorId(int idActivo);
        public Task<List<TblActivo>> ObtenerTodos();
        public Task Actualizar(TblActivo activo);
        public Task Eliminar(int idActivo);
    }
}