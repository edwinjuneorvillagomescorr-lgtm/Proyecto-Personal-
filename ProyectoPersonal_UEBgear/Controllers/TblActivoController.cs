using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblActivo;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblActivoController : ControllerBase
    {
        private readonly ITblActivoService _tblActivoService;

        public TblActivoController(ITblActivoService tblActivoService)
        {
            _tblActivoService = tblActivoService;
        }

        [HttpGet("ObtenerActivos")]
        public async Task<ActionResult<List<TblActivoReadDto>>> ObtenerActivos()
        {
            var activos = await _tblActivoService.ObtenerTodos();
            return Ok(activos);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblActivoReadDto>> ObtenerPorId(int idActivo)
        {
            var activo = await _tblActivoService.ObtenerPorId(idActivo);
            return Ok(activo);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idActivo)
        {
            await _tblActivoService.Eliminar(idActivo);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblActivoCreateDto activo)
        {
            await _tblActivoService.Crear(activo);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblActivoUpdateDto activo)
        {
            await _tblActivoService.Actualizar(activo);
            return NoContent();
        }
    }
}