using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblMarca;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblMarcaController : ControllerBase
    {
        private readonly ITblMarcaService _tblMarcaService;

        public TblMarcaController(ITblMarcaService tblMarcaService)
        {
            _tblMarcaService = tblMarcaService;
        }

        [HttpGet("ObtenerMarcas")]
        public async Task<ActionResult<List<TblMarcaReadDto>>> ObtenerMarcas()
        {
            var marcas = await _tblMarcaService.ObtenerTodos();
            return Ok(marcas);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblMarcaReadDto>> ObtenerPorId(int idMarca)
        {
            var marca = await _tblMarcaService.ObtenerPorId(idMarca);
            return Ok(marca);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idMarca)
        {
            await _tblMarcaService.Eliminar(idMarca);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblMarcaCreateDto marca)
        {
            await _tblMarcaService.Crear(marca);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblMarcaUpdateDto marca)
        {
            await _tblMarcaService.Actualizar(marca);
            return NoContent();
        }
    }
}