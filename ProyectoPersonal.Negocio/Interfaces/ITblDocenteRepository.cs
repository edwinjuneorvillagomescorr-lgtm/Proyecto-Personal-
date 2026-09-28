using ProyectoPersonal.Negocio.DTOs.TblDocente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblDocenteService
    {
        Task Crear(TblDocenteCreateDto docente);
        Task Actualizar(TblDocenteUpdateDto docente);
        Task Eliminar(int idDocente);
        Task<TblDocenteReadDto> ObtenerPorId(int idDocente);
        Task<List<TblDocenteReadDto>> ObtenerTodos();
    }
}