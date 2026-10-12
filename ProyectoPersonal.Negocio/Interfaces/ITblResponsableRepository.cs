using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblResponsable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblResponsableService
    {
        Task Crear(TblResponsableCreateDto responsable);
        Task Actualizar(TblResponsableUpdateDto responsable);
        Task Eliminar(int idAdministrativo);
        Task<TblResponsableReadDto> ObtenerPorId(int idAdministrativo);
        Task<List<TblResponsableReadDto>> ObtenerTodos();
    }
}