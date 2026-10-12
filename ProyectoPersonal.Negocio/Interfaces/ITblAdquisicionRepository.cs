using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblAdquisicion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblAdquisicionService
    {
        Task Crear(TblAdquisicionCreateDto adquisicion);
        Task Actualizar(TblAdquisicionUpdateDto adquisicion);
        Task Eliminar(int idAdquisicion);
        Task<TblAdquisicionReadDto> ObtenerPorId(int idAdquisicion);
        Task<List<TblAdquisicionReadDto>> ObtenerTodos();
    }
}