using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblCategorias;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblCategoriasService
    {
        Task Crear(TblCategoriasCreateDto categoria);
        Task Actualizar(TblCategoriasUpdateDto categoria);
        Task Eliminar(int idCategoria);
        Task<TblCategoriasReadDto> ObtenerPorId(int idCategoria);
        Task<List<TblCategoriasReadDto>> ObtenerTodos();
    }
}