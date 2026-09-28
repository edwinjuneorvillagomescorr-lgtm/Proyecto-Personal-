using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Interfaces
{
    public interface ITblPrestamoRepository
    {
        public Task Crear(TblPrestamo prestamo);
        public Task<TblPrestamo> ObtenerPorId(int idPrestamo);
        public Task<List<TblPrestamo>> ObtenerTodos();
        public Task Actualizar(TblPrestamo prestamo);
        public Task Eliminar(int idPrestamo);
    }
}
