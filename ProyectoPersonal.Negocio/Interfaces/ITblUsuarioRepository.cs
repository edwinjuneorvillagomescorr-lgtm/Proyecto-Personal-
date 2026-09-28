using ProyectoPersonal.Negocio.DTOs.TblUsuario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblUsuarioService
    {
        Task Crear(TblUsuarioCreateDto usuario);
        Task Actualizar(TblUsuarioUpdateDto usuario);
        Task Eliminar(int idUsuario);
        Task<TblUsuarioReadDto> ObtenerPorId(int idUsuario);
        Task<List<TblUsuarioReadDto>> ObtenerTodos();
    }
}