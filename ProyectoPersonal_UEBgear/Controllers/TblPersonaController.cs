using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblPersona;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPersonaController : ControllerBase
    {
        private readonly ITblPersonaService _tblPersonaService;
        public TblPersonaController(ITblPersonaService tblPersonaService)
        {
            _tblPersonaService = tblPersonaService;
        }

        [HttpGet("ObtenerPersonas")]
        public async Task<ActionResult<List<TblPersonaReadDto>>> ObtenerPersonas()
        {
            var personas = await _tblPersonaService.ObtenerTodos();
            return Ok(personas);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblPersonaReadDto>> ObtenerPorId(int idPersona)
        {
            var persona = await _tblPersonaService.ObtenerPorId(idPersona);
            return Ok(persona);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idPersona)
        {
            await _tblPersonaService.Eliminar(idPersona);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblPersonaCreateDto persona)
        {
            await _tblPersonaService.Crear(persona);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblPersonaUpdateDto persona)
        {
            await _tblPersonaService.Actualizar(persona);
            return NoContent();
        }
    }
}