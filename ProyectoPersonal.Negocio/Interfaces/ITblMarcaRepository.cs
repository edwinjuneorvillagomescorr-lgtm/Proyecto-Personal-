using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Negocio.DTOs.TblMarca;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblMarcaService
    {
        Task Crear(TblMarcaCreateDto marca);
        Task Actualizar(TblMarcaUpdateDto marca);
        Task Eliminar(int idMarca);
        Task<TblMarcaReadDto> ObtenerPorId(int idMarca);
        Task<List<TblMarcaReadDto>> ObtenerTodos();
    }
}