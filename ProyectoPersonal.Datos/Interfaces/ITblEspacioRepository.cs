using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblEspacioRepository
    {
        public Task Crear(TblEspacio espacio);
        public Task<TblEspacio> ObtenerPorId(int idEspacio);
        public Task<List<TblEspacio>> ObtenerTodos();
        public Task Actualizar(TblEspacio espacio);
        public Task Eliminar(int idEspacio);
    }
}