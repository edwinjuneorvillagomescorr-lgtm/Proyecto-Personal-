using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblProducto;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblProductoController : ControllerBase
    {
        private readonly ITblProductoService _tblProductoService;

        public TblProductoController(ITblProductoService tblProductoService)
        {
            _tblProductoService = tblProductoService;
        }

        [HttpGet("ObtenerProductos")]
        public async Task<ActionResult<List<TblProductoReadDto>>> ObtenerProductos()
        {
            var productos = await _tblProductoService.ObtenerTodos();
            return Ok(productos);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblProductoReadDto>> ObtenerPorId(int idProducto)
        {
            var producto = await _tblProductoService.ObtenerPorId(idProducto);
            return Ok(producto);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idProducto)
        {
            await _tblProductoService.Eliminar(idProducto);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblProductoCreateDto producto)
        {
            await _tblProductoService.Crear(producto);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblProductoUpdateDto producto)
        {
            await _tblProductoService.Actualizar(producto);
            return NoContent();
        }
    }
}