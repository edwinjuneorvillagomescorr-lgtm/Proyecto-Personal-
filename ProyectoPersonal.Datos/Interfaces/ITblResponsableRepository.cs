using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Datos.Interfaces
{
    public interface ITblResponsableRepository
    {
        public Task Crear(TblResponsable responsable);
        public Task<TblResponsable> ObtenerPorId(int idAdministrativo);
        public Task<List<TblResponsable>> ObtenerTodos();
        public Task Actualizar(TblResponsable responsable);
        public Task Eliminar(int idAdministrativo);
    }
}