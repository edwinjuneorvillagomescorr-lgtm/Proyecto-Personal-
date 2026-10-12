using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblDetalle_adquisicion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblDetalle_adquisicionService
    {
        Task Crear(TblDetalle_adquisicionCreateDto detalle);
        Task Actualizar(TblDetalle_adquisicionUpdateDto detalle);
        Task Eliminar(int idDetalleAdquisicion);
        Task<TblDetalle_adquisicionReadDto> ObtenerPorId(int idDetalleAdquisicion);
        Task<List<TblDetalle_adquisicionReadDto>> ObtenerTodos();
    }
}