using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblUsuarioRepository : ITblUsuarioRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblUsuarioRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblUsuario usuario)
        {
            IEnumerable<int> usuarioResult = await _database.GetData<int>("fn_tblusuario_actualizar", new
            {
                p_lUsuario_id = usuario.lUsuario_id,
                p_sUsuario_nm = usuario.sUsuario_nm,
                p_sUsuario_contraseña = usuario.sUsuario_contraseña,
                p_sUsuario_estado = usuario.sUsuario_estado,
                p_lRol_id = usuario.lRol_id,
                p_lPersona_id = usuario.lPersona_id
            });
        }

        public async Task Crear(TblUsuario usuario)
        {
            IEnumerable<int> usuarioResult = await _database.GetData<int>("fn_tblusuario_crear", new
            {
                p_sUsuario_nm = usuario.sUsuario_nm,
                p_sUsuario_contraseña = usuario.sUsuario_contraseña,
                p_lRol_id = usuario.lRol_id,
                p_lPersona_id = usuario.lPersona_id
            });
        }

        public async Task Eliminar(int idUsuario)
        {
            IEnumerable<int> usuarioResult = await _database.GetData<int>("fn_tblusuario_eliminar", new
            {
                p_lUsuario_id = idUsuario
            });
        }

        public async Task<TblUsuario> ObtenerPorId(int idUsuario)
        {
            IEnumerable<TblUsuario> usuarioResult = await _database.GetData<TblUsuario>("fn_tblusuario_obtenerporid", new
            {
                p_lUsuario_id = idUsuario
            });
            return usuarioResult.FirstOrDefault();
        }

        public async Task<List<TblUsuario>> ObtenerTodos()
        {
            IEnumerable<TblUsuario> usuarioResult = await _database.GetData<TblUsuario>("fn_tblusuario_obtenertodos");
            return usuarioResult.ToList();
        }
    }
}   

