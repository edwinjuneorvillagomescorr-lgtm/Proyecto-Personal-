using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblCategorias;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblCategoriasService : ITblCategoriasService
    {
        private readonly ITblCategoriasRepository _tblCategoriasRepository;
        public TblCategoriasService(ITblCategoriasRepository tblCategoriasRepository)
        {
            _tblCategoriasRepository = tblCategoriasRepository;
        }

        public async Task Actualizar(TblCategoriasUpdateDto categoria)
        {
            TblCategorias objCategoria = new TblCategorias
            {
                lCategoria_id = categoria.lCategoria_id,
                sCategoria_nm = categoria.sCategoria_nm,
                sCategoria_desc = categoria.sCategoria_desc,
                sCategoria_estado = categoria.sCategoria_estado
            };
            await _tblCategoriasRepository.Actualizar(objCategoria);
        }

        public async Task Crear(TblCategoriasCreateDto categoria)
        {
            TblCategorias objCategoria = new TblCategorias
            {
                sCategoria_nm = categoria.sCategoria_nm,
                sCategoria_desc = categoria.sCategoria_desc,
                sCategoria_estado = categoria.sCategoria_estado
            };
            await _tblCategoriasRepository.Crear(objCategoria);
        }

        public async Task Eliminar(int idCategoria)
        {
            await _tblCategoriasRepository.Eliminar(idCategoria);
        }

        public async Task<TblCategoriasReadDto> ObtenerPorId(int idCategoria)
        {
            var result = await _tblCategoriasRepository.ObtenerPorId(idCategoria);

            if (result is null) return null;

            return new TblCategoriasReadDto
            {
                lCategoria_id = result.lCategoria_id,
                sCategoria_nm = result.sCategoria_nm,
                sCategoria_desc = result.sCategoria_desc,
                sCategoria_estado = result.sCategoria_estado
            };
        }

        public async Task<List<TblCategoriasReadDto>> ObtenerTodos()
        {
            var categorias = await _tblCategoriasRepository.ObtenerTodos();
            var categoriasDTO = new List<TblCategoriasReadDto>();

            foreach (var categoria in categorias)
            {
                var categoriaDTO = new TblCategoriasReadDto
                {
                    lCategoria_id = categoria.lCategoria_id,
                    sCategoria_nm = categoria.sCategoria_nm,
                    sCategoria_desc = categoria.sCategoria_desc,
                    sCategoria_estado = categoria.sCategoria_estado
                };

                categoriasDTO.Add(categoriaDTO);
            }

            return categoriasDTO;
        }
    }
}