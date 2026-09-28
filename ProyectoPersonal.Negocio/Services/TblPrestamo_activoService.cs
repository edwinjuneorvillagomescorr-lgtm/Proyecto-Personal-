using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblPrestamo_activo;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblPrestamo_activoService : ITblPrestamo_activoService
    {
        private readonly ITblPrestamo_activoRepository _tblPrestamoActivoRepository;
        public TblPrestamo_activoService(ITblPrestamo_activoRepository tblPrestamoActivoRepository)
        {
            _tblPrestamoActivoRepository = tblPrestamoActivoRepository;
        }

        public async Task Actualizar(TblPrestamo_activoUpdateDto prestamoActivo)
        {
            TblPrestamo_activo objPrestamoActivo = new TblPrestamo_activo
            {
                lPrestamo_activo_id = prestamoActivo.lPrestamo_activo_id,
                sPrestamo_activo_estado_del_Activo_en_su_momento = prestamoActivo.sPrestamo_activo_estado_del_Activo_en_su_momento,
                sPrestamo_activo_estado_de_Activo_devuelto_salida = prestamoActivo.sPrestamo_activo_estado_de_Activo_devuelto_salida,
                lPrestamo_id = prestamoActivo.lPrestamo_id,
                lActivo_id = prestamoActivo.lActivo_id
            };
            await _tblPrestamoActivoRepository.Actualizar(objPrestamoActivo);
        }

        public async Task Crear(TblPrestamo_activoCreateDto prestamoActivo)
        {
            TblPrestamo_activo objPrestamoActivo = new TblPrestamo_activo
            {
                sPrestamo_activo_estado_del_Activo_en_su_momento = prestamoActivo.sPrestamo_activo_estado_del_Activo_en_su_momento,
                sPrestamo_activo_estado_de_Activo_devuelto_salida = prestamoActivo.sPrestamo_activo_estado_de_Activo_devuelto_salida,
                lPrestamo_id = prestamoActivo.lPrestamo_id,
                lActivo_id = prestamoActivo.lActivo_id
            };
            await _tblPrestamoActivoRepository.Crear(objPrestamoActivo);
        }

        public async Task Eliminar(int idPrestamoActivo)
        {
            await _tblPrestamoActivoRepository.Eliminar(idPrestamoActivo);
        }

        public async Task<TblPrestamo_activoReadDto> ObtenerPorId(int idPrestamoActivo)
        {
            var result = await _tblPrestamoActivoRepository.ObtenerPorId(idPrestamoActivo);
            if (result is null) return null;
            return new TblPrestamo_activoReadDto
            {
                lPrestamo_activo_id = result.lPrestamo_activo_id,
                sPrestamo_activo_estado_del_Activo_en_su_momento = result.sPrestamo_activo_estado_del_Activo_en_su_momento,
                sPrestamo_activo_estado_de_Activo_devuelto_salida = result.sPrestamo_activo_estado_de_Activo_devuelto_salida,
                lPrestamo_id = result.lPrestamo_id,
                lActivo_id = result.lActivo_id
            };
        }

        public async Task<List<TblPrestamo_activoReadDto>> ObtenerTodos()
        {
            var prestamosActivos = await _tblPrestamoActivoRepository.ObtenerTodos();
            var prestamosActivosDTO = new List<TblPrestamo_activoReadDto>();

            foreach (var prestamoActivo in prestamosActivos)
            {
                var prestamoActivoDTO = new TblPrestamo_activoReadDto
                {
                    lPrestamo_activo_id = prestamoActivo.lPrestamo_activo_id,
                    sPrestamo_activo_estado_del_Activo_en_su_momento = prestamoActivo.sPrestamo_activo_estado_del_Activo_en_su_momento,
                    sPrestamo_activo_estado_de_Activo_devuelto_salida = prestamoActivo.sPrestamo_activo_estado_de_Activo_devuelto_salida,
                    lPrestamo_id = prestamoActivo.lPrestamo_id,
                    lActivo_id = prestamoActivo.lActivo_id
                };
                prestamosActivosDTO.Add(prestamoActivoDTO);
            }

            return prestamosActivosDTO;
        }
    }
}