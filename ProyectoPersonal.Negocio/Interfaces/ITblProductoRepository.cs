using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblProducto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblProductoService
    {
        Task Crear(TblProductoCreateDto producto);
        Task Actualizar(TblProductoUpdateDto producto);
        Task Eliminar(int idProducto);
        Task<TblProductoReadDto> ObtenerPorId(int idProducto);
        Task<List<TblProductoReadDto>> ObtenerTodos();
    }
}