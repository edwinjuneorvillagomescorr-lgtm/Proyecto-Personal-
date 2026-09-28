using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblUsuario;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblUsuarioService : ITblUsuarioService
    {
        private readonly ITblUsuarioRepository _tblUsuarioRepository;
        public TblUsuarioService(ITblUsuarioRepository tblUsuarioRepository)
        {
            _tblUsuarioRepository = tblUsuarioRepository;
        }

        public async Task Actualizar(TblUsuarioUpdateDto usuario)
        {
            TblUsuario objUsuario = new TblUsuario
            {
                lUsuario_id = usuario.lUsuario_id,
                sUsuario_nm = usuario.sUsuario_nm,
                sUsuario_contraseña = usuario.sUsuario_contraseña,
                sUsuario_estado = usuario.sUsuario_estado,
                lRol_id = usuario.lRol_id,
                lPersona_id = usuario.lPersona_id
            };
            await _tblUsuarioRepository.Actualizar(objUsuario);
        }

        public async Task Crear(TblUsuarioCreateDto usuario)
        {
            TblUsuario objUsuario = new TblUsuario
            {
                sUsuario_nm = usuario.sUsuario_nm,
                sUsuario_contraseña = usuario.sUsuario_contraseña,
                lRol_id = usuario.lRol_id,
                lPersona_id = usuario.lPersona_id
            };
            await _tblUsuarioRepository.Crear(objUsuario);
        }

        public async Task Eliminar(int idUsuario)
        {
            await _tblUsuarioRepository.Eliminar(idUsuario);
        }

        public async Task<TblUsuarioReadDto> ObtenerPorId(int idUsuario)
        {
            var result = await _tblUsuarioRepository.ObtenerPorId(idUsuario);
            if (result is null) return null;
            return new TblUsuarioReadDto
            {
                lUsuario_id = result.lUsuario_id,
                sUsuario_nm = result.sUsuario_nm,
                sUsuario_contraseña = result.sUsuario_contraseña,
                sUsuario_estado = result.sUsuario_estado,
                lRol_id = result.lRol_id,
                lPersona_id = result.lPersona_id
            };
        }

        public async Task<List<TblUsuarioReadDto>> ObtenerTodos()
        {
            var usuarios = await _tblUsuarioRepository.ObtenerTodos();
            var usuariosDTO = new List<TblUsuarioReadDto>();

            foreach (var usuario in usuarios)
            {
                var usuarioDTO = new TblUsuarioReadDto
                {
                    lUsuario_id = usuario.lUsuario_id,
                    sUsuario_nm = usuario.sUsuario_nm,
                    sUsuario_contraseña = usuario.sUsuario_contraseña,
                    sUsuario_estado = usuario.sUsuario_estado,
                    lRol_id = usuario.lRol_id,
                    lPersona_id = usuario.lPersona_id
                };
                usuariosDTO.Add(usuarioDTO);
            }

            return usuariosDTO;
        }
    }
}