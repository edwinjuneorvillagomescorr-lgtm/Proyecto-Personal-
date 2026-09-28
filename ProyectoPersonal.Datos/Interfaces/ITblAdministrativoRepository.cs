using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Interfaces
{
    public interface ITblAdministrativoRepository
    {
        public Task Crear(TblAdministrativo administrativo);
        public Task<TblAdministrativo> ObtenerPorId(int idAdministrativo);
        public Task<List<TblAdministrativo>> ObtenerTodos();
        public Task Actualizar(TblAdministrativo administrativo);
        public Task Eliminar(int idAdministrativo);
    }
}
