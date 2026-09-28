using ProyectoPersonal.Negocio.DTOs.TblEstudiante;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblEstudianteService
    {
        Task Crear(TblEstudianteCreateDto estudiante);
        Task Actualizar(TblEstudianteUpdateDto estudiante);
        Task Eliminar(int idEstudiante);
        Task<TblEstudianteReadDto> ObtenerPorId(int idEstudiante);
        Task<List<TblEstudianteReadDto>> ObtenerTodos();
    }
}