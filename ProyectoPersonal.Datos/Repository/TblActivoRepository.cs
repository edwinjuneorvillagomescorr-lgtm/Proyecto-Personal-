using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblActivoRepository : ITblActivoRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblActivoRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblActivo activo)
        {
            IEnumerable<int> activoResult = await _database.GetData<int>("fn_tblactivo_actualizar", new
            {
                p_lActivo_id = activo.lActivo_id,
                p_sActivo_nm = activo.sActivo_nm,
                p_sActivo_CodUnico = activo.sActivo_CodUnico,
                p_sActivo_fecha_registro = activo.sActivo_fecha_registro,
                p_sActivo_Estado = activo.sActivo_Estado,
                p_lEspacio_id = activo.lEspacio_id,
                p_lCategoria_id = activo.lCategoria_id,
                p_lProducto_id = activo.lProducto_id
            });
        }

        public async Task Crear(TblActivo activo)
        {
            IEnumerable<int> activoResult = await _database.GetData<int>("fn_tblactivo_crear", new
            {
                p_sActivo_nm = activo.sActivo_nm,
                p_sActivo_CodUnico = activo.sActivo_CodUnico,
                p_sActivo_fecha_registro = activo.sActivo_fecha_registro,
                p_sActivo_Estado = activo.sActivo_Estado,
                p_lEspacio_id = activo.lEspacio_id,
                p_lCategoria_id = activo.lCategoria_id,
                p_lProducto_id = activo.lProducto_id
            });
        }

        public async Task Eliminar(int idActivo)
        {
            IEnumerable<int> activoResult = await _database.GetData<int>("fn_tblactivo_eliminar", new
            {
                p_lActivo_id = idActivo
            });
        }

        public async Task<TblActivo> ObtenerPorId(int idActivo)
        {
            IEnumerable<TblActivo> activoResult = await _database.GetData<TblActivo>("fn_tblactivo_obtenerporid", new
            {
                p_lActivo_id = idActivo
            });
            return activoResult.FirstOrDefault();
        }

        public async Task<List<TblActivo>> ObtenerTodos()
        {
            IEnumerable<TblActivo> activoResult = await _database.GetData<TblActivo>("fn_tblactivo_obtenertodos");
            return activoResult.ToList();
        }
    }
}