using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblDetalle_adquisicionRepository
    {
        public Task Crear(TblDetalle_adquisicion detalle);
        public Task<TblDetalle_adquisicion> ObtenerPorId(int idDetalleAdquisicion);
        public Task<List<TblDetalle_adquisicion>> ObtenerTodos();
        public Task Actualizar(TblDetalle_adquisicion detalle);
        public Task Eliminar(int idDetalleAdquisicion);
    }
}