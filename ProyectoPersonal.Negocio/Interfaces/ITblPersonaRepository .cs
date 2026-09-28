using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblPersona;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;   // 👈 este es el que falta

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblPersonaService
    {
        Task Crear(TblPersonaCreateDto persona);
        Task Actualizar(TblPersonaUpdateDto persona);
        Task Eliminar(int idPersona);
        Task<TblPersonaReadDto> ObtenerPorId(int idPersona);
        Task<List<TblPersonaReadDto>> ObtenerTodos();
    }
}