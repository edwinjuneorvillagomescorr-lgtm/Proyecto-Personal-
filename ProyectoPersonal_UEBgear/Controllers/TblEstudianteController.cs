using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblEstudiante;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEstudianteController : ControllerBase
    {
        private readonly ITblEstudianteService _tblEstudianteService;
        public TblEstudianteController(ITblEstudianteService tblEstudianteService)
        {
            _tblEstudianteService = tblEstudianteService;
        }

        [HttpGet("ObtenerEstudiantes")]
        public async Task<ActionResult<List<TblEstudianteReadDto>>> ObtenerEstudiantes()
        {
            var estudiantes = await _tblEstudianteService.ObtenerTodos();
            return Ok(estudiantes);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblEstudianteReadDto>> ObtenerPorId(int idEstudiante)
        {
            var estudiante = await _tblEstudianteService.ObtenerPorId(idEstudiante);
            return Ok(estudiante);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idEstudiante)
        {
            await _tblEstudianteService.Eliminar(idEstudiante);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblEstudianteCreateDto estudiante)
        {
            await _tblEstudianteService.Crear(estudiante);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblEstudianteUpdateDto estudiante)
        {
            await _tblEstudianteService.Actualizar(estudiante);
            return NoContent();
        }
    }
}