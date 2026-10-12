using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblAdquisicionRepository
    {
        public Task Crear(TblAdquisicion adquisicion);
        public Task<TblAdquisicion> ObtenerPorId(int idAdquisicion);
        public Task<List<TblAdquisicion>> ObtenerTodos();
        public Task Actualizar(TblAdquisicion adquisicion);
        public Task Eliminar(int idAdquisicion);
    }
}