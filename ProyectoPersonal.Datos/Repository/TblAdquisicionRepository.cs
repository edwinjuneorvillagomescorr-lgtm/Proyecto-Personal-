using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblAdquisicionRepository : ITblAdquisicionRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblAdquisicionRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblAdquisicion adquisicion)
        {
            IEnumerable<int> adquisicionResult = await _database.GetData<int>("fn_tbladquisicion_actualizar", new
            {
                p_lAdquisicion_id = adquisicion.lAdquisicion_id,
                p_sAdquisicion_NumFact = adquisicion.sAdquisicion_NumFact,
                p_sAdquisicion_costo_total = adquisicion.sAdquisicion_costo_total,
                p_sAdquisicion_fecAdq = adquisicion.sAdquisicion_fecAdq
            });
        }

        public async Task Crear(TblAdquisicion adquisicion)
        {
            IEnumerable<int> adquisicionResult = await _database.GetData<int>("fn_tbladquisicion_crear", new
            {
                p_sAdquisicion_NumFact = adquisicion.sAdquisicion_NumFact,
                p_sAdquisicion_costo_total = adquisicion.sAdquisicion_costo_total,
                p_sAdquisicion_fecAdq = adquisicion.sAdquisicion_fecAdq
            });
        }

        public async Task Eliminar(int idAdquisicion)
        {
            IEnumerable<int> adquisicionResult = await _database.GetData<int>("fn_tbladquisicion_eliminar", new
            {
                p_lAdquisicion_id = idAdquisicion
            });
        }

        public async Task<TblAdquisicion> ObtenerPorId(int idAdquisicion)
        {
            IEnumerable<TblAdquisicion> adquisicionResult = await _database.GetData<TblAdquisicion>("fn_tbladquisicion_obtenerporid", new
            {
                p_lAdquisicion_id = idAdquisicion
            });
            return adquisicionResult.FirstOrDefault();
        }

        public async Task<List<TblAdquisicion>> ObtenerTodos()
        {
            IEnumerable<TblAdquisicion> adquisicionResult = await _database.GetData<TblAdquisicion>("fn_tbladquisicion_obtenertodos");
            return adquisicionResult.ToList();
        }
    }
}