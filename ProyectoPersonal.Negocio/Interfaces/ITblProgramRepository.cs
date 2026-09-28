using ProyectoPersonal.Negocio.DTOs.TblProgram;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblProgramService
    {
        Task Crear(TblProgramCreateDto program);
        Task Actualizar(TblProgramUpdateDto program);
        Task Eliminar(int idProgram);
        Task<TblProgramReadDto> ObtenerPorId(int idProgram);
        Task<List<TblProgramReadDto>> ObtenerTodos();
    }
}