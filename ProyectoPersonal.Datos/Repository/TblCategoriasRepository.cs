using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblCategoriasRepository : ITblCategoriasRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblCategoriasRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblCategorias categoria)
        {
            IEnumerable<int> categoriaResult = await _database.GetData<int>("fn_tblcategorias_actualizar", new
            {
                p_lCategoria_id = categoria.lCategoria_id,
                p_sCategoria_nm = categoria.sCategoria_nm,
                p_sCategoria_desc = categoria.sCategoria_desc,
                p_sCategoria_estado = categoria.sCategoria_estado
            });
        }

        public async Task Crear(TblCategorias categoria)
        {
            IEnumerable<int> categoriaResult = await _database.GetData<int>("fn_tblcategorias_crear", new
            {
                p_sCategoria_nm = categoria.sCategoria_nm,
                p_sCategoria_desc = categoria.sCategoria_desc,
                p_sCategoria_estado = categoria.sCategoria_estado
            });
        }

        public async Task Eliminar(int idCategoria)
        {
            IEnumerable<int> categoriaResult = await _database.GetData<int>("fn_tblcategorias_eliminar", new
            {
                p_lCategoria_id = idCategoria
            });
        }

        public async Task<TblCategorias> ObtenerPorId(int idCategoria)
        {
            IEnumerable<TblCategorias> categoriaResult = await _database.GetData<TblCategorias>("fn_tblcategorias_obtenerporid", new
            {
                p_lCategoria_id = idCategoria
            });
            return categoriaResult.FirstOrDefault();
        }

        public async Task<List<TblCategorias>> ObtenerTodos()
        {
            IEnumerable<TblCategorias> categoriaResult = await _database.GetData<TblCategorias>("fn_tblcategorias_obtenertodos");
            return categoriaResult.ToList();
        }
    }
}