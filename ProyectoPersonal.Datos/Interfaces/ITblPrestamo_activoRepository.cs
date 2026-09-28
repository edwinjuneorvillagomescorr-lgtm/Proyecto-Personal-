using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Interfaces
{
    public interface ITblPrestamo_activoRepository
    {
        public Task Crear(TblPrestamo_activo prestamoActivo);
        public Task<TblPrestamo_activo> ObtenerPorId(int idPrestamoActivo);
        public Task<List<TblPrestamo_activo>> ObtenerTodos();
        public Task Actualizar(TblPrestamo_activo prestamoActivo);
        public Task Eliminar(int idPrestamoActivo);
    }
}
