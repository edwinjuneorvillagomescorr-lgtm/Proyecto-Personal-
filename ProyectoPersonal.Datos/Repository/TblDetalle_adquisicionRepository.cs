using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblDetalle_adquisicionRepository : ITblDetalle_adquisicionRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblDetalle_adquisicionRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblDetalle_adquisicion detalle)
        {
            IEnumerable<int> detalleResult = await _database.GetData<int>("fn_tbldetalle_adquisicion_actualizar", new
            {
                p_lDetalle_adquisicion_id = detalle.lDetalle_adquisicion_id,
                p_sDetalle_adquisicion_Cantidad = detalle.sDetalle_adquisicion_Cantidad,
                p_lAdquisicion_id = detalle.lAdquisicion_id,
                p_lProducto_id = detalle.lProducto_id
            });
        }

        public async Task Crear(TblDetalle_adquisicion detalle)
        {
            IEnumerable<int> detalleResult = await _database.GetData<int>("fn_tbldetalle_adquisicion_crear", new
            {
                p_sDetalle_adquisicion_Cantidad = detalle.sDetalle_adquisicion_Cantidad,
                p_lAdquisicion_id = detalle.lAdquisicion_id,
                p_lProducto_id = detalle.lProducto_id
            });
        }

        public async Task Eliminar(int idDetalleAdquisicion)
        {
            IEnumerable<int> detalleResult = await _database.GetData<int>("fn_tbldetalle_adquisicion_eliminar", new
            {
                p_lDetalle_adquisicion_id = idDetalleAdquisicion
            });
        }

        public async Task<TblDetalle_adquisicion> ObtenerPorId(int idDetalleAdquisicion)
        {
            IEnumerable<TblDetalle_adquisicion> detalleResult = await _database.GetData<TblDetalle_adquisicion>("fn_tbldetalle_adquisicion_obtenerporid", new
            {
                p_lDetalle_adquisicion_id = idDetalleAdquisicion
            });
            return detalleResult.FirstOrDefault();
        }

        public async Task<List<TblDetalle_adquisicion>> ObtenerTodos()
        {
            IEnumerable<TblDetalle_adquisicion> detalleResult = await _database.GetData<TblDetalle_adquisicion>("fn_tbldetalle_adquisicion_obtenertodos");
            return detalleResult.ToList();
        }
    }
}