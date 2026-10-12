using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblMarcaRepository
    {
        public Task Crear(TblMarca marca);
        public Task<TblMarca> ObtenerPorId(int idMarca);
        public Task<List<TblMarca>> ObtenerTodos();
        public Task Actualizar(TblMarca marca);
        public Task Eliminar(int idMarca);
    }
}