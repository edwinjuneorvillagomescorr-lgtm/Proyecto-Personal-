using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblTransferencia_activo;
using ProyectoPersonal.Negocio.Interfaces;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblTransferencia_activoController : ControllerBase
    {
        private readonly ITblTransferencia_activoService _tblTransferencia_activoService;

        public TblTransferencia_activoController(ITblTransferencia_activoService tblTransferencia_activoService)
        {
            _tblTransferencia_activoService = tblTransferencia_activoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var result = await _tblTransferencia_activoService.ObtenerTodos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var result = await _tblTransferencia_activoService.ObtenerPorId(id);
            if (result is null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(TblTransferencia_activoCreateDto dto)
        {
            await _tblTransferencia_activoService.Crear(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(TblTransferencia_activoUpdateDto dto)
        {
            await _tblTransferencia_activoService.Actualizar(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _tblTransferencia_activoService.Eliminar(id);
            return Ok();
        }
    }
}