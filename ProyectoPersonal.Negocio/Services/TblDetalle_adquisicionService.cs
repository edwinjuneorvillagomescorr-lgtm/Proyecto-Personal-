using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblDetalle_adquisicion;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblDetalle_adquisicionService : ITblDetalle_adquisicionService
    {
        private readonly ITblDetalle_adquisicionRepository _tblDetalle_adquisicionRepository;
        public TblDetalle_adquisicionService(ITblDetalle_adquisicionRepository tblDetalle_adquisicionRepository)
        {
            _tblDetalle_adquisicionRepository = tblDetalle_adquisicionRepository;
        }

        public async Task Actualizar(TblDetalle_adquisicionUpdateDto detalle)
        {
            TblDetalle_adquisicion objDetalle = new TblDetalle_adquisicion
            {
                lDetalle_adquisicion_id = detalle.lDetalle_adquisicion_id,
                sDetalle_adquisicion_Cantidad = detalle.sDetalle_adquisicion_Cantidad,
                lAdquisicion_id = detalle.lAdquisicion_id,
                lProducto_id = detalle.lProducto_id
            };
            await _tblDetalle_adquisicionRepository.Actualizar(objDetalle);
        }

        public async Task Crear(TblDetalle_adquisicionCreateDto detalle)
        {
            TblDetalle_adquisicion objDetalle = new TblDetalle_adquisicion
            {
                sDetalle_adquisicion_Cantidad = detalle.sDetalle_adquisicion_Cantidad,
                lAdquisicion_id = detalle.lAdquisicion_id,
                lProducto_id = detalle.lProducto_id
            };
            await _tblDetalle_adquisicionRepository.Crear(objDetalle);
        }

        public async Task Eliminar(int idDetalleAdquisicion)
        {
            await _tblDetalle_adquisicionRepository.Eliminar(idDetalleAdquisicion);
        }

        public async Task<TblDetalle_adquisicionReadDto> ObtenerPorId(int idDetalleAdquisicion)
        {
            var result = await _tblDetalle_adquisicionRepository.ObtenerPorId(idDetalleAdquisicion);

            if (result is null) return null;

            return new TblDetalle_adquisicionReadDto
            {
                lDetalle_adquisicion_id = result.lDetalle_adquisicion_id,
                sDetalle_adquisicion_Cantidad = result.sDetalle_adquisicion_Cantidad,
                lAdquisicion_id = result.lAdquisicion_id,
                lProducto_id = result.lProducto_id
            };
        }

        public async Task<List<TblDetalle_adquisicionReadDto>> ObtenerTodos()
        {
            var detalles = await _tblDetalle_adquisicionRepository.ObtenerTodos();
            var detallesDTO = new List<TblDetalle_adquisicionReadDto>();

            foreach (var detalle in detalles)
            {
                var detalleDTO = new TblDetalle_adquisicionReadDto
                {
                    lDetalle_adquisicion_id = detalle.lDetalle_adquisicion_id,
                    sDetalle_adquisicion_Cantidad = detalle.sDetalle_adquisicion_Cantidad,
                    lAdquisicion_id = detalle.lAdquisicion_id,
                    lProducto_id = detalle.lProducto_id
                };

                detallesDTO.Add(detalleDTO);
            }

            return detallesDTO;
        }
    }
}