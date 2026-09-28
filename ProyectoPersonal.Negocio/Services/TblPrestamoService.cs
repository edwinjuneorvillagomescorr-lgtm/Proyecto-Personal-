using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblPrestamo;
using ProyectoPersonal.Negocio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblPrestamoService : ITblPrestamoService
    {
        private readonly ITblPrestamoRepository _tblPrestamoRepository;
        public TblPrestamoService(ITblPrestamoRepository tblPrestamoRepository)
        {
            _tblPrestamoRepository = tblPrestamoRepository;
        }

        public async Task Actualizar(TblPrestamoUpdateDto prestamo)
        {
            TblPrestamo objPrestamo = new TblPrestamo
            {
                lPrestamo_id = prestamo.lPrestamo_id,
                sPrestamo_fecha_salida = prestamo.sPrestamo_fecha_salida,
                sPrestamo_fecha_limite = prestamo.sPrestamo_fecha_limite,
                sPrestamo_fecha_devolucion = prestamo.sPrestamo_fecha_devolucion,
                sPrestamo_estado = prestamo.sPrestamo_estado,
                sPrestamo_desc = prestamo.sPrestamo_desc,
                sPersona_tipo = prestamo.sPersona_tipo,
                lPersona_id = prestamo.lPersona_id,
                lSolicitante_id = prestamo.lSolicitante_id
            };
            await _tblPrestamoRepository.Actualizar(objPrestamo);
        }

        public async Task Crear(TblPrestamoCreateDto prestamo)
        {
            TblPrestamo objPrestamo = new TblPrestamo
            {
                sPrestamo_fecha_salida = prestamo.sPrestamo_fecha_salida,
                sPrestamo_fecha_limite = prestamo.sPrestamo_fecha_limite,
                sPrestamo_estado = prestamo.sPrestamo_estado,
                sPrestamo_desc = prestamo.sPrestamo_desc,
                sPersona_tipo = prestamo.sPersona_tipo,
                lPersona_id = prestamo.lPersona_id,
                lSolicitante_id = prestamo.lSolicitante_id
            };
            await _tblPrestamoRepository.Crear(objPrestamo);
        }

        public async Task Eliminar(int idPrestamo)
        {
            await _tblPrestamoRepository.Eliminar(idPrestamo);
        }

        public async Task<TblPrestamoReadDto> ObtenerPorId(int idPrestamo)
        {
            var result = await _tblPrestamoRepository.ObtenerPorId(idPrestamo);
            if (result is null) return null;

            return new TblPrestamoReadDto
            {
                lPrestamo_id = result.lPrestamo_id,
                sPrestamo_fecha_salida = result.sPrestamo_fecha_salida,
                sPrestamo_fecha_limite = result.sPrestamo_fecha_limite,
                sPrestamo_fecha_devolucion = result.sPrestamo_fecha_devolucion,
                sPrestamo_estado = result.sPrestamo_estado,
                sPrestamo_desc = result.sPrestamo_desc,
                sPersona_tipo = result.sPersona_tipo,
                lPersona_id = result.lPersona_id,
                lSolicitante_id = result.lSolicitante_id
            };
        }

        public async Task<List<TblPrestamoReadDto>> ObtenerTodos()
        {
            var prestamos = await _tblPrestamoRepository.ObtenerTodos();
            var prestamosDTO = new List<TblPrestamoReadDto>();

            foreach (var prestamo in prestamos)
            {
                var prestamoDTO = new TblPrestamoReadDto
                {
                    lPrestamo_id = prestamo.lPrestamo_id,
                    sPrestamo_fecha_salida = prestamo.sPrestamo_fecha_salida,
                    sPrestamo_fecha_limite = prestamo.sPrestamo_fecha_limite,
                    sPrestamo_fecha_devolucion = prestamo.sPrestamo_fecha_devolucion,
                    sPrestamo_estado = prestamo.sPrestamo_estado,
                    sPrestamo_desc = prestamo.sPrestamo_desc,
                    sPersona_tipo = prestamo.sPersona_tipo,
                    lPersona_id = prestamo.lPersona_id,
                    lSolicitante_id = prestamo.lSolicitante_id
                };
                prestamosDTO.Add(prestamoDTO);
            }

            return prestamosDTO;
        }
    }
}