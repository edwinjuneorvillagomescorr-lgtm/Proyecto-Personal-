using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblRol;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblRolController : ControllerBase
    {
        private readonly ITblRolService _tblRolService;
        public TblRolController(ITblRolService tblRolService)
        {
            _tblRolService = tblRolService;
        }

        [HttpGet("ObtenerRoles")]
        public async Task<ActionResult<List<TblRolReadDto>>> ObtenerRoles()
        {
            var roles = await _tblRolService.ObtenerTodos();
            return Ok(roles);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblRolReadDto>> ObtenerPorId(int idRol)
        {
            var rol = await _tblRolService.ObtenerPorId(idRol);
            return Ok(rol);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idRol)
        {
            await _tblRolService.Eliminar(idRol);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblRolCreateDto rol)
        {
            await _tblRolService.Crear(rol);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblRolUpdateDto rol)
        {
            await _tblRolService.Actualizar(rol);
            return NoContent();
        }
    }
}