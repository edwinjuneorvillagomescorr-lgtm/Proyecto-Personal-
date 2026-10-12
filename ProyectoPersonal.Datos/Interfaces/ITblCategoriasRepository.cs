using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblCategoriasRepository
    {
        public Task Crear(TblCategorias categoria);
        public Task<TblCategorias> ObtenerPorId(int idCategoria);
        public Task<List<TblCategorias>> ObtenerTodos();
        public Task Actualizar(TblCategorias categoria);
        public Task Eliminar(int idCategoria);
    }
}