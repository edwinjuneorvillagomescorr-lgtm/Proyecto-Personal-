using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblAdquisicion;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAdquisicionController : ControllerBase
    {
        private readonly ITblAdquisicionService _tblAdquisicionService;

        public TblAdquisicionController(ITblAdquisicionService tblAdquisicionService)
        {
            _tblAdquisicionService = tblAdquisicionService;
        }

        [HttpGet("ObtenerAdquisiciones")]
        public async Task<ActionResult<List<TblAdquisicionReadDto>>> ObtenerAdquisiciones()
        {
            var adquisiciones = await _tblAdquisicionService.ObtenerTodos();
            return Ok(adquisiciones);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblAdquisicionReadDto>> ObtenerPorId(int idAdquisicion)
        {
            var adquisicion = await _tblAdquisicionService.ObtenerPorId(idAdquisicion);
            return Ok(adquisicion);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idAdquisicion)
        {
            await _tblAdquisicionService.Eliminar(idAdquisicion);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblAdquisicionCreateDto adquisicion)
        {
            await _tblAdquisicionService.Crear(adquisicion);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblAdquisicionUpdateDto adquisicion)
        {
            await _tblAdquisicionService.Actualizar(adquisicion);
            return NoContent();
        }
    }
}