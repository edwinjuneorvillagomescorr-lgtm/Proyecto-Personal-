using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblAreaRepository
    {
        public Task Crear(TblArea area);
        public Task<TblArea> ObtenerPorId(int idArea);
        public Task<List<TblArea>> ObtenerTodos();
        public Task Actualizar(TblArea area);
        public Task Eliminar(int idArea);
    }
}