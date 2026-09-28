using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblPermisosRepository : ITblPermisosRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblPermisosRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblPermisos permisos)
        {
            IEnumerable<int> permisosResult = await _database.GetData<int>("fn_tblpermisos_actualizar", new
            {
                p_lPermisos_id = permisos.lPermisos_id,
                p_Insertar = permisos.Insertar,
                p_Consultar = permisos.Consultar,
                p_Actualizar = permisos.Actualizar,
                p_Eliminar = permisos.Eliminar,
                p_lRol_id = permisos.lRol_id,
                p_lProgram_id = permisos.lProgram_id
            });
        }

        public async Task Crear(TblPermisos permisos)
        {
            IEnumerable<int> permisosResult = await _database.GetData<int>("fn_tblpermisos_crear", new
            {
                p_Insertar = permisos.Insertar,
                p_Consultar = permisos.Consultar,
                p_Actualizar = permisos.Actualizar,
                p_Eliminar = permisos.Eliminar,
                p_lRol_id = permisos.lRol_id,
                p_lProgram_id = permisos.lProgram_id
            });
        }

        public async Task Eliminar(int idPermisos)
        {
            IEnumerable<int> permisosResult = await _database.GetData<int>("fn_tblpermisos_eliminar", new
            {
                p_lPermisos_id = idPermisos
            });
        }

        public async Task<TblPermisos> ObtenerPorId(int idPermisos)
        {
            IEnumerable<TblPermisos> permisosResult = await _database.GetData<TblPermisos>("fn_tblpermisos_obtenerporid", new
            {
                p_lPermisos_id = idPermisos
            });
            return permisosResult.FirstOrDefault();
        }

        public async Task<List<TblPermisos>> ObtenerTodos()
        {
            IEnumerable<TblPermisos> permisosResult = await _database.GetData<TblPermisos>("fn_tblpermisos_obtenertodos");
            return permisosResult.ToList();
        }
    }
}
