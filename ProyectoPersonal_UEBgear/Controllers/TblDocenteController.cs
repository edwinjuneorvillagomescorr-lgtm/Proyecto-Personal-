using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblDocente;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblDocenteController : ControllerBase
    {
        private readonly ITblDocenteService _tblDocenteService;
        public TblDocenteController(ITblDocenteService tblDocenteService)
        {
            _tblDocenteService = tblDocenteService;
        }

        [HttpGet("ObtenerDocentes")]
        public async Task<ActionResult<List<TblDocenteReadDto>>> ObtenerDocentes()
        {
            var docentes = await _tblDocenteService.ObtenerTodos();
            return Ok(docentes);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblDocenteReadDto>> ObtenerPorId(int idDocente)
        {
            var docente = await _tblDocenteService.ObtenerPorId(idDocente);
            return Ok(docente);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idDocente)
        {
            await _tblDocenteService.Eliminar(idDocente);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblDocenteCreateDto docente)
        {
            await _tblDocenteService.Crear(docente);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblDocenteUpdateDto docente)
        {
            await _tblDocenteService.Actualizar(docente);
            return NoContent();
        }
    }
}