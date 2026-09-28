using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Interfaces
{
    public interface ITblTransferencia_activoRepository
    {
        public Task Crear(TblTransferencia_activo transferenciaActivo);
        public Task<TblTransferencia_activo> ObtenerPorId(int idTransferenciaActivo);
        public Task<List<TblTransferencia_activo>> ObtenerTodos();
        public Task Actualizar(TblTransferencia_activo transferenciaActivo);
        public Task Eliminar(int idTransferenciaActivo);
    }
}
