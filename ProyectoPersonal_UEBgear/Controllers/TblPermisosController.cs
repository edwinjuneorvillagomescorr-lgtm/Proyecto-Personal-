using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblPermisos;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPermisosController : ControllerBase
    {
        private readonly ITblPermisosService _tblPermisosService;
        public TblPermisosController(ITblPermisosService tblPermisosService)
        {
            _tblPermisosService = tblPermisosService;
        }

        [HttpGet("ObtenerPermisos")]
        public async Task<ActionResult<List<TblPermisosReadDto>>> ObtenerPermisos()
        {
            var permisos = await _tblPermisosService.ObtenerTodos();
            return Ok(permisos);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblPermisosReadDto>> ObtenerPorId(int idPermisos)
        {
            var permiso = await _tblPermisosService.ObtenerPorId(idPermisos);
            return Ok(permiso);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idPermisos)
        {
            await _tblPermisosService.Eliminar(idPermisos);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblPermisosCreateDto permisos)
        {
            await _tblPermisosService.Crear(permisos);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblPermisosUpdateDto permisos)
        {
            await _tblPermisosService.Actualizar(permisos);
            return NoContent();
        }
    }
}