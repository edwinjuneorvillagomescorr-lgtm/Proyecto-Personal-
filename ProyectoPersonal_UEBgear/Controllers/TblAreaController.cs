using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblArea;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAreaController : ControllerBase
    {
        private readonly ITblAreaService _tblAreaService;
        public TblAreaController(ITblAreaService tblAreaService)
        {
            _tblAreaService = tblAreaService;
        }

        [HttpGet("ObtenerAreas")]
        public async Task<ActionResult<List<TblAreaReadDto>>> ObtenerAreas()
        {
            var areas = await _tblAreaService.ObtenerTodos();
            return Ok(areas);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblAreaReadDto>> ObtenerPorId(int idArea)
        {
            var area = await _tblAreaService.ObtenerPorId(idArea);
            return Ok(area);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idArea)
        {
            await _tblAreaService.Eliminar(idArea);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblAreaCreateDto area)
        {
            await _tblAreaService.Crear(area);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblAreaUpdateDto area)
        {
            await _tblAreaService.Actualizar(area);
            return NoContent();
        }
    }
}