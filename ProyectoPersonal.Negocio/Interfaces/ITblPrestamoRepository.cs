using ProyectoPersonal.Negocio.DTOs.TblPrestamo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblPrestamoService
    {
        Task Crear(TblPrestamoCreateDto prestamo);
        Task Actualizar(TblPrestamoUpdateDto prestamo);
        Task Eliminar(int idPrestamo);
        Task<TblPrestamoReadDto> ObtenerPorId(int idPrestamo);
        Task<List<TblPrestamoReadDto>> ObtenerTodos();
    }
}