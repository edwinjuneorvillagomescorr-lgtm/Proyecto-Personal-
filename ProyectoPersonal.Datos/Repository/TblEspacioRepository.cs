using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblEspacioRepository : ITblEspacioRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblEspacioRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblEspacio espacio)
        {
            IEnumerable<int> espacioResult = await _database.GetData<int>("fn_tblespacio_actualizar", new
            {
                p_lEspacio_id = espacio.lEspacio_id,
                p_sEspacio_nm = espacio.sEspacio_nm,
                p_sEspacio_tipo = espacio.sEspacio_tipo,
                p_sEspacio_capacidad = espacio.sEspacio_capacidad,
                p_sEspacio_estado = espacio.sEspacio_estado,
                p_lEdificio_id = espacio.lEdificio_id
            });
        }

        public async Task Crear(TblEspacio espacio)
        {
            IEnumerable<int> espacioResult = await _database.GetData<int>("fn_tblespacio_crear", new
            {
                p_sEspacio_nm = espacio.sEspacio_nm,
                p_sEspacio_tipo = espacio.sEspacio_tipo,
                p_sEspacio_capacidad = espacio.sEspacio_capacidad,
                p_sEspacio_estado = espacio.sEspacio_estado,
                p_lEdificio_id = espacio.lEdificio_id
            });
        }

        public async Task Eliminar(int idEspacio)
        {
            IEnumerable<int> espacioResult = await _database.GetData<int>("fn_tblespacio_eliminar", new
            {
                p_lEspacio_id = idEspacio
            });
        }

        public async Task<TblEspacio> ObtenerPorId(int idEspacio)
        {
            IEnumerable<TblEspacio> espacioResult = await _database.GetData<TblEspacio>("fn_tblespacio_obtenerporid", new
            {
                p_lEspacio_id = idEspacio
            });
            return espacioResult.FirstOrDefault();
        }

        public async Task<List<TblEspacio>> ObtenerTodos()
        {
            IEnumerable<TblEspacio> espacioResult = await _database.GetData<TblEspacio>("fn_tblespacio_obtenertodos");
            return espacioResult.ToList();
        }
    }
}