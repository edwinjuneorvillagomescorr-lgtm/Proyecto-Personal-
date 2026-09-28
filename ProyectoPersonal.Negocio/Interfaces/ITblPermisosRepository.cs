using ProyectoPersonal.Negocio.DTOs.TblPermisos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblPermisosService
    {
        Task Crear(TblPermisosCreateDto permisos);
        Task Actualizar(TblPermisosUpdateDto permisos);
        Task Eliminar(int idPermisos);
        Task<TblPermisosReadDto> ObtenerPorId(int idPermisos);
        Task<List<TblPermisosReadDto>> ObtenerTodos();
    }
}