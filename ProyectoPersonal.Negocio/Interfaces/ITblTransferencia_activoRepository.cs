using ProyectoPersonal.Negocio.DTOs.TblTransferencia_activo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Interfaces
{
    public interface ITblTransferencia_activoService
    {
        Task Crear(TblTransferencia_activoCreateDto transferenciaActivo);
        Task Actualizar(TblTransferencia_activoUpdateDto transferenciaActivo);
        Task Eliminar(int idTransferenciaActivo);
        Task<TblTransferencia_activoReadDto> ObtenerPorId(int idTransferenciaActivo);
        Task<List<TblTransferencia_activoReadDto>> ObtenerTodos();
    }
}