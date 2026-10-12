using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblAdquisicion;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblAdquisicionService : ITblAdquisicionService
    {
        private readonly ITblAdquisicionRepository _tblAdquisicionRepository;
        public TblAdquisicionService(ITblAdquisicionRepository tblAdquisicionRepository)
        {
            _tblAdquisicionRepository = tblAdquisicionRepository;
        }

        public async Task Actualizar(TblAdquisicionUpdateDto adquisicion)
        {
            TblAdquisicion objAdquisicion = new TblAdquisicion
            {
                lAdquisicion_id = adquisicion.lAdquisicion_id,
                sAdquisicion_NumFact = adquisicion.sAdquisicion_NumFact,
                sAdquisicion_costo_total = adquisicion.sAdquisicion_costo_total,
                sAdquisicion_fecAdq = adquisicion.sAdquisicion_fecAdq
            };
            await _tblAdquisicionRepository.Actualizar(objAdquisicion);
        }

        public async Task Crear(TblAdquisicionCreateDto adquisicion)
        {
            TblAdquisicion objAdquisicion = new TblAdquisicion
            {
                sAdquisicion_NumFact = adquisicion.sAdquisicion_NumFact,
                sAdquisicion_costo_total = adquisicion.sAdquisicion_costo_total,
                sAdquisicion_fecAdq = adquisicion.sAdquisicion_fecAdq
            };
            await _tblAdquisicionRepository.Crear(objAdquisicion);
        }

        public async Task Eliminar(int idAdquisicion)
        {
            await _tblAdquisicionRepository.Eliminar(idAdquisicion);
        }

        public async Task<TblAdquisicionReadDto> ObtenerPorId(int idAdquisicion)
        {
            var result = await _tblAdquisicionRepository.ObtenerPorId(idAdquisicion);

            if (result is null) return null;

            return new TblAdquisicionReadDto
            {
                lAdquisicion_id = result.lAdquisicion_id,
                sAdquisicion_NumFact = result.sAdquisicion_NumFact,
                sAdquisicion_costo_total = result.sAdquisicion_costo_total,
                sAdquisicion_fecAdq = result.sAdquisicion_fecAdq
            };
        }

        public async Task<List<TblAdquisicionReadDto>> ObtenerTodos()
        {
            var adquisiciones = await _tblAdquisicionRepository.ObtenerTodos();
            var adquisicionesDTO = new List<TblAdquisicionReadDto>();

            foreach (var adquisicion in adquisiciones)
            {
                var adquisicionDTO = new TblAdquisicionReadDto
                {
                    lAdquisicion_id = adquisicion.lAdquisicion_id,
                    sAdquisicion_NumFact = adquisicion.sAdquisicion_NumFact,
                    sAdquisicion_costo_total = adquisicion.sAdquisicion_costo_total,
                    sAdquisicion_fecAdq = adquisicion.sAdquisicion_fecAdq
                };

                adquisicionesDTO.Add(adquisicionDTO);
            }

            return adquisicionesDTO;
        }
    }
}