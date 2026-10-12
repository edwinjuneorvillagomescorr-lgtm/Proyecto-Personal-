using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblDetalle_adquisicion;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblDetalle_adquisicionController : ControllerBase
    {
        private readonly ITblDetalle_adquisicionService _tblDetalle_adquisicionService;

        public TblDetalle_adquisicionController(ITblDetalle_adquisicionService tblDetalle_adquisicionService)
        {
            _tblDetalle_adquisicionService = tblDetalle_adquisicionService;
        }

        [HttpGet("ObtenerDetalles")]
        public async Task<ActionResult<List<TblDetalle_adquisicionReadDto>>> ObtenerDetalles()
        {
            var detalles = await _tblDetalle_adquisicionService.ObtenerTodos();
            return Ok(detalles);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblDetalle_adquisicionReadDto>> ObtenerPorId(int idDetalleAdquisicion)
        {
            var detalle = await _tblDetalle_adquisicionService.ObtenerPorId(idDetalleAdquisicion);
            return Ok(detalle);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idDetalleAdquisicion)
        {
            await _tblDetalle_adquisicionService.Eliminar(idDetalleAdquisicion);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblDetalle_adquisicionCreateDto detalle)
        {
            await _tblDetalle_adquisicionService.Crear(detalle);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblDetalle_adquisicionUpdateDto detalle)
        {
            await _tblDetalle_adquisicionService.Actualizar(detalle);
            return NoContent();
        }
    }
}