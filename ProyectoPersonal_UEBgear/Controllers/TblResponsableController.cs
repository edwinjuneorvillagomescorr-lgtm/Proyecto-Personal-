using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblResponsable;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblResponsableController : ControllerBase
    {
        private readonly ITblResponsableService _tblResponsableService;

        public TblResponsableController(ITblResponsableService tblResponsableService)
        {
            _tblResponsableService = tblResponsableService;
        }

        [HttpGet("ObtenerResponsables")]
        public async Task<ActionResult<List<TblResponsableReadDto>>> ObtenerResponsables()
        {
            var responsables = await _tblResponsableService.ObtenerTodos();
            return Ok(responsables);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblResponsableReadDto>> ObtenerPorId(int idAdministrativo)
        {
            var responsable = await _tblResponsableService.ObtenerPorId(idAdministrativo);
            return Ok(responsable);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idAdministrativo)
        {
            await _tblResponsableService.Eliminar(idAdministrativo);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblResponsableCreateDto responsable)
        {
            await _tblResponsableService.Crear(responsable);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblResponsableUpdateDto responsable)
        {
            await _tblResponsableService.Actualizar(responsable);
            return NoContent();
        }
    }
}