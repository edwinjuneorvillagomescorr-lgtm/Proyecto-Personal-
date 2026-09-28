using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblAdministrativo;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAdministrativoController : ControllerBase
    {
        private readonly ITblAdministrativoService _tblAdministrativoService;
        public TblAdministrativoController(ITblAdministrativoService tblAdministrativoService)
        {
            _tblAdministrativoService = tblAdministrativoService;
        }

        [HttpGet("ObtenerAdministrativos")]
        public async Task<ActionResult<List<TblAdministrativoReadDto>>> ObtenerAdministrativos()
        {
            var administrativos = await _tblAdministrativoService.ObtenerTodos();
            return Ok(administrativos);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblAdministrativoReadDto>> ObtenerPorId(int idAdministrativo)
        {
            var administrativo = await _tblAdministrativoService.ObtenerPorId(idAdministrativo);
            return Ok(administrativo);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idAdministrativo)
        {
            await _tblAdministrativoService.Eliminar(idAdministrativo);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblAdministrativoCreateDto administrativo)
        {
            await _tblAdministrativoService.Crear(administrativo);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblAdministrativoUpdateDto administrativo)
        {
            await _tblAdministrativoService.Actualizar(administrativo);
            return NoContent();
        }
    }
}