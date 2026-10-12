using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblMarca;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblMarcaService : ITblMarcaService
    {
        private readonly ITblMarcaRepository _tblMarcaRepository;
        public TblMarcaService(ITblMarcaRepository tblMarcaRepository)
        {
            _tblMarcaRepository = tblMarcaRepository;
        }

        public async Task Actualizar(TblMarcaUpdateDto marca)
        {
            TblMarca objMarca = new TblMarca
            {
                lMarca_id = marca.lMarca_id,
                sMarca_nm = marca.sMarca_nm
            };
            await _tblMarcaRepository.Actualizar(objMarca);
        }

        public async Task Crear(TblMarcaCreateDto marca)
        {
            TblMarca objMarca = new TblMarca
            {
                sMarca_nm = marca.sMarca_nm
            };
            await _tblMarcaRepository.Crear(objMarca);
        }

        public async Task Eliminar(int idMarca)
        {
            await _tblMarcaRepository.Eliminar(idMarca);
        }

        public async Task<TblMarcaReadDto> ObtenerPorId(int idMarca)
        {
            var result = await _tblMarcaRepository.ObtenerPorId(idMarca);

            if (result is null) return null;

            return new TblMarcaReadDto
            {
                lMarca_id = result.lMarca_id,
                sMarca_nm = result.sMarca_nm
            };
        }

        public async Task<List<TblMarcaReadDto>> ObtenerTodos()
        {
            var marcas = await _tblMarcaRepository.ObtenerTodos();
            var marcasDTO = new List<TblMarcaReadDto>();

            foreach (var marca in marcas)
            {
                var marcaDTO = new TblMarcaReadDto
                {
                    lMarca_id = marca.lMarca_id,
                    sMarca_nm = marca.sMarca_nm
                };

                marcasDTO.Add(marcaDTO);
            }

            return marcasDTO;
        }
    }
}