using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblRolRepository : ITblRolRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblRolRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblRol rol)
        {
            IEnumerable<int> rolResult = await _database.GetData<int>("fn_tblrol_actualizar", new
            {
                p_lRol_id = rol.lRol_id,
                p_sRol_nm = rol.sRol_nm,
                p_sRol_desc = rol.sRol_desc,
                p_sRol_estado = rol.sRol_estado
            });
        }

        public async Task Crear(TblRol rol)
        {
            IEnumerable<int> rolResult = await _database.GetData<int>("fn_tblrol_crear", new
            {
                p_sRol_nm = rol.sRol_nm,
                p_sRol_desc = rol.sRol_desc
            });
        }

        public async Task Eliminar(int idRol)
        {
            IEnumerable<int> rolResult = await _database.GetData<int>("fn_tblrol_eliminar", new
            {
                p_lRol_id = idRol
            });
        }

        public async Task<TblRol> ObtenerPorId(int idRol)
        {
            IEnumerable<TblRol> rolResult = await _database.GetData<TblRol>("fn_tblrol_obtenerporid", new
            {
                p_lRol_id = idRol
            });
            return rolResult.FirstOrDefault();
        }

        public async Task<List<TblRol>> ObtenerTodos()
        {
            IEnumerable<TblRol> rolResult = await _database.GetData<TblRol>("fn_tblrol_obtenertodos");
            return rolResult.ToList();
        }
    }
}
