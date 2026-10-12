using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblEdificio;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblEdificioService : ITblEdificioService
    {
        private readonly ITblEdificioRepository _tblEdificioRepository;
        public TblEdificioService(ITblEdificioRepository tblEdificioRepository)
        {
            _tblEdificioRepository = tblEdificioRepository;
        }

        public async Task Actualizar(TblEdificioUpdateDto edificio)
        {
            TblEdificio objEdificio = new TblEdificio
            {
                lEdificio_id = edificio.lEdificio_id,
                sEdificio_nm = edificio.sEdificio_nm,
                sEdificio_cantidad_pisos = edificio.sEdificio_cantidad_pisos,
                sEdificio_estado = edificio.sEdificio_estado,
                lArea_id = edificio.lArea_id
            };
            await _tblEdificioRepository.Actualizar(objEdificio);
        }

        public async Task Crear(TblEdificioCreateDto edificio)
        {
            TblEdificio objEdificio = new TblEdificio
            {
                sEdificio_nm = edificio.sEdificio_nm,
                sEdificio_cantidad_pisos = edificio.sEdificio_cantidad_pisos,
                sEdificio_estado = edificio.sEdificio_estado,
                lArea_id = edificio.lArea_id
            };
            await _tblEdificioRepository.Crear(objEdificio);
        }

        public async Task Eliminar(int idEdificio)
        {
            await _tblEdificioRepository.Eliminar(idEdificio);
        }

        public async Task<TblEdificioReadDto> ObtenerPorId(int idEdificio)
        {
            var result = await _tblEdificioRepository.ObtenerPorId(idEdificio);

            if (result is null) return null;

            return new TblEdificioReadDto
            {
                lEdificio_id = result.lEdificio_id,
                sEdificio_nm = result.sEdificio_nm,
                sEdificio_cantidad_pisos = result.sEdificio_cantidad_pisos,
                sEdificio_estado = result.sEdificio_estado,
                lArea_id = result.lArea_id
            };
        }

        public async Task<List<TblEdificioReadDto>> ObtenerTodos()
        {
            var edificios = await _tblEdificioRepository.ObtenerTodos();
            var edificiosDTO = new List<TblEdificioReadDto>();

            foreach (var edificio in edificios)
            {
                var edificioDTO = new TblEdificioReadDto
                {
                    lEdificio_id = edificio.lEdificio_id,
                    sEdificio_nm = edificio.sEdificio_nm,
                    sEdificio_cantidad_pisos = edificio.sEdificio_cantidad_pisos,
                    sEdificio_estado = edificio.sEdificio_estado,
                    lArea_id = edificio.lArea_id
                };

                edificiosDTO.Add(edificioDTO);
            }

            return edificiosDTO;
        }
    }
}