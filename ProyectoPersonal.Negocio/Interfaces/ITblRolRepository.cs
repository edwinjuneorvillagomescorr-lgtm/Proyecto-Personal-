using ProyectoPersonal.Negocio.DTOs.TblRol;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblRolService
    {
        Task Crear(TblRolCreateDto rol);
        Task Actualizar(TblRolUpdateDto rol);
        Task Eliminar(int idRol);
        Task<TblRolReadDto> ObtenerPorId(int idRol);
        Task<List<TblRolReadDto>> ObtenerTodos();
    }
}