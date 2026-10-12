using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblProducto;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblProductoService : ITblProductoService
    {
        private readonly ITblProductoRepository _tblProductoRepository;
        public TblProductoService(ITblProductoRepository tblProductoRepository)
        {
            _tblProductoRepository = tblProductoRepository;
        }

        public async Task Actualizar(TblProductoUpdateDto producto)
        {
            TblProducto objProducto = new TblProducto
            {
                lProducto_id = producto.lProducto_id,
                sProducto_nm = producto.sProducto_nm,
                sProducto_desc = producto.sProducto_desc,
                sProducto_numSerie = producto.sProducto_numSerie,
                lMarca_id = producto.lMarca_id
            };
            await _tblProductoRepository.Actualizar(objProducto);
        }

        public async Task Crear(TblProductoCreateDto producto)
        {
            TblProducto objProducto = new TblProducto
            {
                sProducto_nm = producto.sProducto_nm,
                sProducto_desc = producto.sProducto_desc,
                sProducto_numSerie = producto.sProducto_numSerie,
                lMarca_id = producto.lMarca_id
            };
            await _tblProductoRepository.Crear(objProducto);
        }

        public async Task Eliminar(int idProducto)
        {
            await _tblProductoRepository.Eliminar(idProducto);
        }

        public async Task<TblProductoReadDto> ObtenerPorId(int idProducto)
        {
            var result = await _tblProductoRepository.ObtenerPorId(idProducto);

            if (result is null) return null;

            return new TblProductoReadDto
            {
                lProducto_id = result.lProducto_id,
                sProducto_nm = result.sProducto_nm,
                sProducto_desc = result.sProducto_desc,
                sProducto_numSerie = result.sProducto_numSerie,
                lMarca_id = result.lMarca_id
            };
        }

        public async Task<List<TblProductoReadDto>> ObtenerTodos()
        {
            var productos = await _tblProductoRepository.ObtenerTodos();
            var productosDTO = new List<TblProductoReadDto>();

            foreach (var producto in productos)
            {
                var productoDTO = new TblProductoReadDto
                {
                    lProducto_id = producto.lProducto_id,
                    sProducto_nm = producto.sProducto_nm,
                    sProducto_desc = producto.sProducto_desc,
                    sProducto_numSerie = producto.sProducto_numSerie,
                    lMarca_id = producto.lMarca_id
                };

                productosDTO.Add(productoDTO);
            }

            return productosDTO;
        }
    }
}