using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblEspacio;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblEspacioService : ITblEspacioService
    {
        private readonly ITblEspacioRepository _tblEspacioRepository;
        public TblEspacioService(ITblEspacioRepository tblEspacioRepository)
        {
            _tblEspacioRepository = tblEspacioRepository;
        }

        public async Task Actualizar(TblEspacioUpdateDto espacio)
        {
            TblEspacio objEspacio = new TblEspacio
            {
                lEspacio_id = espacio.lEspacio_id,
                sEspacio_nm = espacio.sEspacio_nm,
                sEspacio_tipo = espacio.sEspacio_tipo,
                sEspacio_capacidad = espacio.sEspacio_capacidad,
                sEspacio_estado = espacio.sEspacio_estado,
                lEdificio_id = espacio.lEdificio_id
            };
            await _tblEspacioRepository.Actualizar(objEspacio);
        }

        public async Task Crear(TblEspacioCreateDto espacio)
        {
            TblEspacio objEspacio = new TblEspacio
            {
                sEspacio_nm = espacio.sEspacio_nm,
                sEspacio_tipo = espacio.sEspacio_tipo,
                sEspacio_capacidad = espacio.sEspacio_capacidad,
                sEspacio_estado = espacio.sEspacio_estado,
                lEdificio_id = espacio.lEdificio_id
            };
            await _tblEspacioRepository.Crear(objEspacio);
        }

        public async Task Eliminar(int idEspacio)
        {
            await _tblEspacioRepository.Eliminar(idEspacio);
        }

        public async Task<TblEspacioReadDto> ObtenerPorId(int idEspacio)
        {
            var result = await _tblEspacioRepository.ObtenerPorId(idEspacio);

            if (result is null) return null;

            return new TblEspacioReadDto
            {
                lEspacio_id = result.lEspacio_id,
                sEspacio_nm = result.sEspacio_nm,
                sEspacio_tipo = result.sEspacio_tipo,
                sEspacio_capacidad = result.sEspacio_capacidad,
                sEspacio_estado = result.sEspacio_estado,
                lEdificio_id = result.lEdificio_id
            };
        }

        public async Task<List<TblEspacioReadDto>> ObtenerTodos()
        {
            var espacios = await _tblEspacioRepository.ObtenerTodos();
            var espaciosDTO = new List<TblEspacioReadDto>();

            foreach (var espacio in espacios)
            {
                var espacioDTO = new TblEspacioReadDto
                {
                    lEspacio_id = espacio.lEspacio_id,
                    sEspacio_nm = espacio.sEspacio_nm,
                    sEspacio_tipo = espacio.sEspacio_tipo,
                    sEspacio_capacidad = espacio.sEspacio_capacidad,
                    sEspacio_estado = espacio.sEspacio_estado,
                    lEdificio_id = espacio.lEdificio_id
                };

                espaciosDTO.Add(espacioDTO);
            }

            return espaciosDTO;
        }
    }
}