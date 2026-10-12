using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblEdificioRepository : ITblEdificioRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblEdificioRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblEdificio edificio)
        {
            IEnumerable<int> edificioResult = await _database.GetData<int>("fn_tbledificio_actualizar", new
            {
                p_lEdificio_id = edificio.lEdificio_id,
                p_sEdificio_nm = edificio.sEdificio_nm,
                p_sEdificio_cantidad_pisos = edificio.sEdificio_cantidad_pisos,
                p_sEdificio_estado = edificio.sEdificio_estado,
                p_lArea_id = edificio.lArea_id
            });
        }

        public async Task Crear(TblEdificio edificio)
        {
            IEnumerable<int> edificioResult = await _database.GetData<int>("fn_tbledificio_crear", new
            {
                p_sEdificio_nm = edificio.sEdificio_nm,
                p_sEdificio_cantidad_pisos = edificio.sEdificio_cantidad_pisos,
                p_sEdificio_estado = edificio.sEdificio_estado,
                p_lArea_id = edificio.lArea_id
            });
        }

        public async Task Eliminar(int idEdificio)
        {
            IEnumerable<int> edificioResult = await _database.GetData<int>("fn_tbledificio_eliminar", new
            {
                p_lEdificio_id = idEdificio
            });
        }

        public async Task<TblEdificio> ObtenerPorId(int idEdificio)
        {
            IEnumerable<TblEdificio> edificioResult = await _database.GetData<TblEdificio>("fn_tbledificio_obtenerporid", new
            {
                p_lEdificio_id = idEdificio
            });
            return edificioResult.FirstOrDefault();
        }

        public async Task<List<TblEdificio>> ObtenerTodos()
        {
            IEnumerable<TblEdificio> edificioResult = await _database.GetData<TblEdificio>("fn_tbledificio_obtenertodos");
            return edificioResult.ToList();
        }
    }
}