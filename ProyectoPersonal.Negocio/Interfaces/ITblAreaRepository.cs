using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblArea;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblAreaService
    {
        Task Crear(TblAreaCreateDto area);
        Task Actualizar(TblAreaUpdateDto area);
        Task Eliminar(int idArea);
        Task<TblAreaReadDto> ObtenerPorId(int idArea);
        Task<List<TblAreaReadDto>> ObtenerTodos();
    }
}