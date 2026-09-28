using Microsoft.AspNetCore.Mvc;
using ProyectoPersonal.Negocio.DTOs.TblPrestamo;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPrestamoController : ControllerBase
    {
        private readonly ITblPrestamoService _tblPrestamoService;
        public TblPrestamoController(ITblPrestamoService tblPrestamoService)
        {
            _tblPrestamoService = tblPrestamoService;
        }

        [HttpGet("ObtenerPrestamos")]
        public async Task<ActionResult<List<TblPrestamoReadDto>>> ObtenerPrestamos()
        {
            var prestamos = await _tblPrestamoService.ObtenerTodos();
            return Ok(prestamos);
        }

        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblPrestamoReadDto>> ObtenerPorId(int idPrestamo)
        {
            var prestamo = await _tblPrestamoService.ObtenerPorId(idPrestamo);
            return Ok(prestamo);
        }

        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idPrestamo)
        {
            await _tblPrestamoService.Eliminar(idPrestamo);
            return NoContent();
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblPrestamoCreateDto prestamo)
        {
            await _tblPrestamoService.Crear(prestamo);
            return Created();
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblPrestamoUpdateDto prestamo)
        {
            await _tblPrestamoService.Actualizar(prestamo);
            return NoContent();
        }
    }
}