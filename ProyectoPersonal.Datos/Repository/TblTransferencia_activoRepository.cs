using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblTransferencia_activoRepository : ITblTransferencia_activoRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblTransferencia_activoRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblTransferencia_activo transferenciaActivo)
        {
            IEnumerable<int> transferenciaActivoResult = await _database.GetData<int>("fn_tbltransferencia_activo_actualizar", new
            {
                p_lTransferencia_activo_id = transferenciaActivo.lTransferencia_activo_id,
                p_sTransferencia_activo_nm = transferenciaActivo.sTransferencia_activo_nm,
                p_sTransferencia_activo_origen = transferenciaActivo.sTransferencia_activo_origen,
                p_sTransferencia_activo_destino = transferenciaActivo.sTransferencia_activo_destino,
                p_sTransferencia_activo_responsable = transferenciaActivo.sTransferencia_activo_responsable,
                p_sTransferencia_activo_fecha = transferenciaActivo.sTransferencia_activo_fecha,
                p_sTransferencia_activo_estado = transferenciaActivo.sTransferencia_activo_estado,
                p_lActivo_id = transferenciaActivo.lActivo_id,
                p_lEspacio_origen_id = transferenciaActivo.lEspacio_origen_id,
                p_lEspacio_destino_id = transferenciaActivo.lEspacio_destino_id,
                p_lPersona_id = transferenciaActivo.lPersona_id
            });
        }

        public async Task Crear(TblTransferencia_activo transferenciaActivo)
        {
            IEnumerable<int> transferenciaActivoResult = await _database.GetData<int>("fn_tbltransferencia_activo_crear", new
            {
                p_sTransferencia_activo_nm = transferenciaActivo.sTransferencia_activo_nm,
                p_sTransferencia_activo_origen = transferenciaActivo.sTransferencia_activo_origen,
                p_sTransferencia_activo_destino = transferenciaActivo.sTransferencia_activo_destino,
                p_sTransferencia_activo_responsable = transferenciaActivo.sTransferencia_activo_responsable,
                p_sTransferencia_activo_fecha = transferenciaActivo.sTransferencia_activo_fecha,
                p_sTransferencia_activo_estado = transferenciaActivo.sTransferencia_activo_estado,
                p_lActivo_id = transferenciaActivo.lActivo_id,
                p_lEspacio_origen_id = transferenciaActivo.lEspacio_origen_id,
                p_lEspacio_destino_id = transferenciaActivo.lEspacio_destino_id,
                p_lPersona_id = transferenciaActivo.lPersona_id
            });
        }

        public async Task Eliminar(int idTransferenciaActivo)
        {
            IEnumerable<int> transferenciaActivoResult = await _database.GetData<int>("fn_tbltransferencia_activo_eliminar", new
            {
                p_lTransferencia_activo_id = idTransferenciaActivo
            });
        }

        public async Task<TblTransferencia_activo> ObtenerPorId(int idTransferenciaActivo)
        {
            IEnumerable<TblTransferencia_activo> transferenciaActivoResult = await _database.GetData<TblTransferencia_activo>("fn_tbltransferencia_activo_obtenerporid", new
            {
                p_lTransferencia_activo_id = idTransferenciaActivo
            });
            return transferenciaActivoResult.FirstOrDefault();
        }

        public async Task<List<TblTransferencia_activo>> ObtenerTodos()
        {
            IEnumerable<TblTransferencia_activo> transferenciaActivoResult = await _database.GetData<TblTransferencia_activo>("fn_tbltransferencia_activo_obtenertodos");
            return transferenciaActivoResult.ToList();
        }
    }
}
