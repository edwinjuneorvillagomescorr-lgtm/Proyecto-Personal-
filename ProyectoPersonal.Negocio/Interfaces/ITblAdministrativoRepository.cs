using ProyectoPersonal.Negocio.DTOs.TblAdministrativo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblAdministrativoService
    {
        Task Crear(TblAdministrativoCreateDto administrativo);
        Task Actualizar(TblAdministrativoUpdateDto administrativo);
        Task Eliminar(int idAdministrativo);
        Task<TblAdministrativoReadDto> ObtenerPorId(int idAdministrativo);
        Task<List<TblAdministrativoReadDto>> ObtenerTodos();
    }
}