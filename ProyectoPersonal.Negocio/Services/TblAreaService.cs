using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblArea;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblAreaService : ITblAreaService
    {
        private readonly ITblAreaRepository _tblAreaRepository;
        public TblAreaService(ITblAreaRepository tblAreaRepository)
        {
            _tblAreaRepository = tblAreaRepository;
        }

        public async Task Actualizar(TblAreaUpdateDto area)
        {
            TblArea objArea = new TblArea
            {
                lArea_id = area.lArea_id,
                sArea_nm = area.sArea_nm,
                sArea_Sector = area.sArea_Sector,
                sArea_tipo = area.sArea_tipo
            };
            await _tblAreaRepository.Actualizar(objArea);
        }

        public async Task Crear(TblAreaCreateDto area)
        {
            TblArea objArea = new TblArea
            {
                sArea_nm = area.sArea_nm,
                sArea_Sector = area.sArea_Sector,
                sArea_tipo = area.sArea_tipo
            };
            await _tblAreaRepository.Crear(objArea);
        }

        public async Task Eliminar(int idArea)
        {
            await _tblAreaRepository.Eliminar(idArea);
        }

        public async Task<TblAreaReadDto> ObtenerPorId(int idArea)
        {
            var result = await _tblAreaRepository.ObtenerPorId(idArea);
            if (result is null) return null;
            return new TblAreaReadDto
            {
                lArea_id = result.lArea_id,
                sArea_nm = result.sArea_nm,
                sArea_Sector = result.sArea_Sector,
                sArea_tipo = result.sArea_tipo
            };
        }

        public async Task<List<TblAreaReadDto>> ObtenerTodos()
        {
            var areas = await _tblAreaRepository.ObtenerTodos();
            var areasDTO = new List<TblAreaReadDto>();

            foreach (var area in areas)
            {
                var areaDTO = new TblAreaReadDto
                {
                    lArea_id = area.lArea_id,
                    sArea_nm = area.sArea_nm,
                    sArea_Sector = area.sArea_Sector,
                    sArea_tipo = area.sArea_tipo
                };
                areasDTO.Add(areaDTO);
            }

            return areasDTO;
        }
    }
}