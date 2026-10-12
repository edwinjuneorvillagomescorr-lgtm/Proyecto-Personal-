using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblProductoRepository
    {
        public Task Crear(TblProducto producto);
        public Task<TblProducto> ObtenerPorId(int idProducto);
        public Task<List<TblProducto>> ObtenerTodos();
        public Task Actualizar(TblProducto producto);
        public Task Eliminar(int idProducto);
    }
}