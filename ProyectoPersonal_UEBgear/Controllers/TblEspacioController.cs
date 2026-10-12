using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblEspacio;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEspacioController : ControllerBase
    {
        private readonly ITblEspacioService _tblEspacioService;

        public TblEspacioController(ITblEspacioService tblEspacioService)
        {
            _tblEspacioService = tblEspacioService;
        }

        [HttpGet("ObtenerEspacios")]
        public async Task<ActionResult<List<TblEspacioReadDto>>> ObtenerEspacios()
        {
            var espacios = await _tblEspacioService.ObtenerTodos();
            return Ok(espacios);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblEspacioReadDto>> ObtenerPorId(int idEspacio)
        {
            var espacio = await _tblEspacioService.ObtenerPorId(idEspacio);
            return Ok(espacio);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idEspacio)
        {
            await _tblEspacioService.Eliminar(idEspacio);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblEspacioCreateDto espacio)
        {
            await _tblEspacioService.Crear(espacio);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblEspacioUpdateDto espacio)
        {
            await _tblEspacioService.Actualizar(espacio);
            return NoContent();
        }
    }
}