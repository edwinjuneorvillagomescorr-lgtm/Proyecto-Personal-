using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblEdificio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblEdificioService
    {
        Task Crear(TblEdificioCreateDto edificio);
        Task Actualizar(TblEdificioUpdateDto edificio);
        Task Eliminar(int idEdificio);
        Task<TblEdificioReadDto> ObtenerPorId(int idEdificio);
        Task<List<TblEdificioReadDto>> ObtenerTodos();
    }
}