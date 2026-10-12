using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblMarcaRepository : ITblMarcaRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblMarcaRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblMarca marca)
        {
            IEnumerable<int> marcaResult = await _database.GetData<int>("fn_tblmarca_actualizar", new
            {
                p_lMarca_id = marca.lMarca_id,
                p_sMarca_nm = marca.sMarca_nm
            });
        }

        public async Task Crear(TblMarca marca)
        {
            IEnumerable<int> marcaResult = await _database.GetData<int>("fn_tblmarca_crear", new
            {
                p_sMarca_nm = marca.sMarca_nm
            });
        }

        public async Task Eliminar(int idMarca)
        {
            IEnumerable<int> marcaResult = await _database.GetData<int>("fn_tblmarca_eliminar", new
            {
                p_lMarca_id = idMarca
            });
        }

        public async Task<TblMarca> ObtenerPorId(int idMarca)
        {
            IEnumerable<TblMarca> marcaResult = await _database.GetData<TblMarca>("fn_tblmarca_obtenerporid", new
            {
                p_lMarca_id = idMarca
            });
            return marcaResult.FirstOrDefault();
        }

        public async Task<List<TblMarca>> ObtenerTodos()
        {
            IEnumerable<TblMarca> marcaResult = await _database.GetData<TblMarca>("fn_tblmarca_obtenertodos");
            return marcaResult.ToList();
        }
    }
}