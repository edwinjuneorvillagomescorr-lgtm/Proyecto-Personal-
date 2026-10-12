using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblActivo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblActivoService
    {
        Task Crear(TblActivoCreateDto activo);
        Task Actualizar(TblActivoUpdateDto activo);
        Task Eliminar(int idActivo);
        Task<TblActivoReadDto> ObtenerPorId(int idActivo);
        Task<List<TblActivoReadDto>> ObtenerTodos();
    }
}