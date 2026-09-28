using ProyectoPersonal.Negocio.DTOs.TblPrestamo_activo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblPrestamo_activoService
    {
        Task Crear(TblPrestamo_activoCreateDto prestamoActivo);
        Task Actualizar(TblPrestamo_activoUpdateDto prestamoActivo);
        Task Eliminar(int idPrestamoActivo);
        Task<TblPrestamo_activoReadDto> ObtenerPorId(int idPrestamoActivo);
        Task<List<TblPrestamo_activoReadDto>> ObtenerTodos();
    }
}