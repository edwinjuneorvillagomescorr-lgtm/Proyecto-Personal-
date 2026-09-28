using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblProgram;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblProgramController : ControllerBase
    {
        private readonly ITblProgramService _tblProgramService;
        public TblProgramController(ITblProgramService tblProgramService)
        {
            _tblProgramService = tblProgramService;
        }

        [HttpGet("ObtenerProgramas")]
        public async Task<ActionResult<List<TblProgramReadDto>>> ObtenerProgramas()
        {
            var programas = await _tblProgramService.ObtenerTodos();
            return Ok(programas);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblProgramReadDto>> ObtenerPorId(int idProgram)
        {
            var programa = await _tblProgramService.ObtenerPorId(idProgram);
            return Ok(programa);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idProgram)
        {
            await _tblProgramService.Eliminar(idProgram);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblProgramCreateDto program)
        {
            await _tblProgramService.Crear(program);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblProgramUpdateDto program)
        {
            await _tblProgramService.Actualizar(program);
            return NoContent();
        }
    }
}
