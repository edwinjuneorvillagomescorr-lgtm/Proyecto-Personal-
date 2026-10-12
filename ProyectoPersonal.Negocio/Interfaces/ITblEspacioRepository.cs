using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblEspacio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblEspacioService
    {
        Task Crear(TblEspacioCreateDto espacio);
        Task Actualizar(TblEspacioUpdateDto espacio);
        Task Eliminar(int idEspacio);
        Task<TblEspacioReadDto> ObtenerPorId(int idEspacio);
        Task<List<TblEspacioReadDto>> ObtenerTodos();
    }
}