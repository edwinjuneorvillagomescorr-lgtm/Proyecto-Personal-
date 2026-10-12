using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblCategorias;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblCategoriasController : ControllerBase
    {
        private readonly ITblCategoriasService _tblCategoriasService;

        public TblCategoriasController(ITblCategoriasService tblCategoriasService)
        {
            _tblCategoriasService = tblCategoriasService;
        }

        [HttpGet("ObtenerCategorias")]
        public async Task<ActionResult<List<TblCategoriasReadDto>>> ObtenerCategorias()
        {
            var categorias = await _tblCategoriasService.ObtenerTodos();
            return Ok(categorias);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblCategoriasReadDto>> ObtenerPorId(int idCategoria)
        {
            var categoria = await _tblCategoriasService.ObtenerPorId(idCategoria);
            return Ok(categoria);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idCategoria)
        {
            await _tblCategoriasService.Eliminar(idCategoria);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblCategoriasCreateDto categoria)
        {
            await _tblCategoriasService.Crear(categoria);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblCategoriasUpdateDto categoria)
        {
            await _tblCategoriasService.Actualizar(categoria);
            return NoContent();
        }
    }
}