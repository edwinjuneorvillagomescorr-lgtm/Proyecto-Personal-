using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblPrestamo_activo;
using ProyectoPersonal.Negocio.Interfaces;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPrestamo_activoController : ControllerBase
    {
        private readonly ITblPrestamo_activoService _tblPrestamo_activoService;

        public TblPrestamo_activoController(ITblPrestamo_activoService tblPrestamo_activoService)
        {
            _tblPrestamo_activoService = tblPrestamo_activoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var result = await _tblPrestamo_activoService.ObtenerTodos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var result = await _tblPrestamo_activoService.ObtenerPorId(id);
            if (result is null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(TblPrestamo_activoCreateDto dto)
        {
            await _tblPrestamo_activoService.Crear(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(TblPrestamo_activoUpdateDto dto)
        {
            await _tblPrestamo_activoService.Actualizar(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _tblPrestamo_activoService.Eliminar(id);
            return Ok();
        }
    }
}