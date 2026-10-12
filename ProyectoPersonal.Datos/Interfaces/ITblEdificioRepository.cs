using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblEdificioRepository
    {
        public Task Crear(TblEdificio edificio);
        public Task<TblEdificio> ObtenerPorId(int idEdificio);
        public Task<List<TblEdificio>> ObtenerTodos();
        public Task Actualizar(TblEdificio edificio);
        public Task Eliminar(int idEdificio);
    }
}