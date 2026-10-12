using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblAreaRepository : ITblAreaRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblAreaRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblArea area)
        {
            IEnumerable<int> areaResult = await _database.GetData<int>("fn_tblarea_actualizar", new
            {
                p_lArea_id = area.lArea_id,
                p_sArea_nm = area.sArea_nm,
                p_sArea_Sector = area.sArea_Sector,
                p_sArea_tipo = area.sArea_tipo
            });
        }

        public async Task Crear(TblArea area)
        {
            IEnumerable<int> areaResult = await _database.GetData<int>("fn_tblarea_crear", new
            {
                p_sArea_nm = area.sArea_nm,
                p_sArea_Sector = area.sArea_Sector,
                p_sArea_tipo = area.sArea_tipo
            });
        }

        public async Task Eliminar(int idArea)
        {
            IEnumerable<int> areaResult = await _database.GetData<int>("fn_tblarea_eliminar", new
            {
                p_lArea_id = idArea
            });
        }

        public async Task<TblArea> ObtenerPorId(int idArea)
        {
            IEnumerable<TblArea> areaResult = await _database.GetData<TblArea>("fn_tblarea_obtenerporid", new
            {
                p_lArea_id = idArea
            });
            return areaResult.FirstOrDefault();
        }

        public async Task<List<TblArea>> ObtenerTodos()
        {
            IEnumerable<TblArea> areaResult = await _database.GetData<TblArea>("fn_tblarea_obtenertodos");
            return areaResult.ToList();
        }
    }
}