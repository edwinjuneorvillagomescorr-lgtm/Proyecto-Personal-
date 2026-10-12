using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblEdificio;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEdificioController : ControllerBase
    {
        private readonly ITblEdificioService _tblEdificioService;

        public TblEdificioController(ITblEdificioService tblEdificioService)
        {
            _tblEdificioService = tblEdificioService;
        }

        [HttpGet("ObtenerEdificios")]
        public async Task<ActionResult<List<TblEdificioReadDto>>> ObtenerEdificios()
        {
            var edificios = await _tblEdificioService.ObtenerTodos();
            return Ok(edificios);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblEdificioReadDto>> ObtenerPorId(int idEdificio)
        {
            var edificio = await _tblEdificioService.ObtenerPorId(idEdificio);
            return Ok(edificio);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idEdificio)
        {
            await _tblEdificioService.Eliminar(idEdificio);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblEdificioCreateDto edificio)
        {
            await _tblEdificioService.Crear(edificio);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblEdificioUpdateDto edificio)
        {
            await _tblEdificioService.Actualizar(edificio);
            return NoContent();
        }
    }
}