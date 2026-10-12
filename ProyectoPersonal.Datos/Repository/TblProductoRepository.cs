using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblProductoRepository : ITblProductoRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblProductoRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblProducto producto)
        {
            IEnumerable<int> productoResult = await _database.GetData<int>("fn_tblproducto_actualizar", new
            {
                p_lProducto_id = producto.lProducto_id,
                p_sProducto_nm = producto.sProducto_nm,
                p_sProducto_desc = producto.sProducto_desc,
                p_sProducto_numSerie = producto.sProducto_numSerie,
                p_lMarca_id = producto.lMarca_id
            });
        }

        public async Task Crear(TblProducto producto)
        {
            IEnumerable<int> productoResult = await _database.GetData<int>("fn_tblproducto_crear", new
            {
                p_sProducto_nm = producto.sProducto_nm,
                p_sProducto_desc = producto.sProducto_desc,
                p_sProducto_numSerie = producto.sProducto_numSerie,
                p_lMarca_id = producto.lMarca_id
            });
        }

        public async Task Eliminar(int idProducto)
        {
            IEnumerable<int> productoResult = await _database.GetData<int>("fn_tblproducto_eliminar", new
            {
                p_lProducto_id = idProducto
            });
        }

        public async Task<TblProducto> ObtenerPorId(int idProducto)
        {
            IEnumerable<TblProducto> productoResult = await _database.GetData<TblProducto>("fn_tblproducto_obtenerporid", new
            {
                p_lProducto_id = idProducto
            });
            return productoResult.FirstOrDefault();
        }

        public async Task<List<TblProducto>> ObtenerTodos()
        {
            IEnumerable<TblProducto> productoResult = await _database.GetData<TblProducto>("fn_tblproducto_obtenertodos");
            return productoResult.ToList();
        }
    }
}