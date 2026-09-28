using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblTransferencia_activo;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblTransferencia_activoService : ITblTransferencia_activoService
    {
        private readonly ITblTransferencia_activoRepository _tblTransferenciaActivoRepository;
        public TblTransferencia_activoService(ITblTransferencia_activoRepository tblTransferenciaActivoRepository)
        {
            _tblTransferenciaActivoRepository = tblTransferenciaActivoRepository;
        }

        public async Task Actualizar(TblTransferencia_activoUpdateDto transferenciaActivo)
        {
            TblTransferencia_activo objTransferenciaActivo = new TblTransferencia_activo
            {
                lTransferencia_activo_id = transferenciaActivo.lTransferencia_activo_id,
                sTransferencia_activo_nm = transferenciaActivo.sTransferencia_activo_nm,
                sTransferencia_activo_origen = transferenciaActivo.sTransferencia_activo_origen,
                sTransferencia_activo_destino = transferenciaActivo.sTransferencia_activo_destino,
                sTransferencia_activo_responsable = transferenciaActivo.sTransferencia_activo_responsable,
                sTransferencia_activo_fecha = transferenciaActivo.sTransferencia_activo_fecha,
                sTransferencia_activo_estado = transferenciaActivo.sTransferencia_activo_estado,
                lActivo_id = transferenciaActivo.lActivo_id,
                lEspacio_origen_id = transferenciaActivo.lEspacio_origen_id,
                lEspacio_destino_id = transferenciaActivo.lEspacio_destino_id,
                lPersona_id = transferenciaActivo.lPersona_id
            };
            await _tblTransferenciaActivoRepository.Actualizar(objTransferenciaActivo);
        }

        public async Task Crear(TblTransferencia_activoCreateDto transferenciaActivo)
        {
            TblTransferencia_activo objTransferenciaActivo = new TblTransferencia_activo
            {
                sTransferencia_activo_nm = transferenciaActivo.sTransferencia_activo_nm,
                sTransferencia_activo_origen = transferenciaActivo.sTransferencia_activo_origen,
                sTransferencia_activo_destino = transferenciaActivo.sTransferencia_activo_destino,
                sTransferencia_activo_responsable = transferenciaActivo.sTransferencia_activo_responsable,
                sTransferencia_activo_fecha = transferenciaActivo.sTransferencia_activo_fecha,
                sTransferencia_activo_estado = transferenciaActivo.sTransferencia_activo_estado,
                lActivo_id = transferenciaActivo.lActivo_id,
                lEspacio_origen_id = transferenciaActivo.lEspacio_origen_id,
                lEspacio_destino_id = transferenciaActivo.lEspacio_destino_id,
                lPersona_id = transferenciaActivo.lPersona_id
            };
            await _tblTransferenciaActivoRepository.Crear(objTransferenciaActivo);
        }

        public async Task Eliminar(int idTransferenciaActivo)
        {
            await _tblTransferenciaActivoRepository.Eliminar(idTransferenciaActivo);
        }

        public async Task<TblTransferencia_activoReadDto> ObtenerPorId(int idTransferenciaActivo)
        {
            var result = await _tblTransferenciaActivoRepository.ObtenerPorId(idTransferenciaActivo);
            if (result is null) return null;
            return new TblTransferencia_activoReadDto
            {
                lTransferencia_activo_id = result.lTransferencia_activo_id,
                sTransferencia_activo_nm = result.sTransferencia_activo_nm,
                sTransferencia_activo_origen = result.sTransferencia_activo_origen,
                sTransferencia_activo_destino = result.sTransferencia_activo_destino,
                sTransferencia_activo_responsable = result.sTransferencia_activo_responsable,
                sTransferencia_activo_fecha = result.sTransferencia_activo_fecha,
                sTransferencia_activo_estado = result.sTransferencia_activo_estado,
                lActivo_id = result.lActivo_id,
                lEspacio_origen_id = result.lEspacio_origen_id,
                lEspacio_destino_id = result.lEspacio_destino_id,
                lPersona_id = result.lPersona_id
            };
        }

        public async Task<List<TblTransferencia_activoReadDto>> ObtenerTodos()
        {
            var transferencias = await _tblTransferenciaActivoRepository.ObtenerTodos();
            var transferenciasDTO = new List<TblTransferencia_activoReadDto>();

            foreach (var transferencia in transferencias)
            {
                var transferenciaDTO = new TblTransferencia_activoReadDto
                {
                    lTransferencia_activo_id = transferencia.lTransferencia_activo_id,
                    sTransferencia_activo_nm = transferencia.sTransferencia_activo_nm,
                    sTransferencia_activo_origen = transferencia.sTransferencia_activo_origen,
                    sTransferencia_activo_destino = transferencia.sTransferencia_activo_destino,
                    sTransferencia_activo_responsable = transferencia.sTransferencia_activo_responsable,
                    sTransferencia_activo_fecha = transferencia.sTransferencia_activo_fecha,
                    sTransferencia_activo_estado = transferencia.sTransferencia_activo_estado,
                    lActivo_id = transferencia.lActivo_id,
                    lEspacio_origen_id = transferencia.lEspacio_origen_id,
                    lEspacio_destino_id = transferencia.lEspacio_destino_id,
                    lPersona_id = transferencia.lPersona_id
                };
                transferenciasDTO.Add(transferenciaDTO);
            }

            return transferenciasDTO;
        }
    }
}