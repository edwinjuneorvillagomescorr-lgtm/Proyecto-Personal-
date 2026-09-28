using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblRol;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblRolService : ITblRolService
    {
        private readonly ITblRolRepository _tblRolRepository;
        public TblRolService(ITblRolRepository tblRolRepository)
        {
            _tblRolRepository = tblRolRepository;
        }

        public async Task Actualizar(TblRolUpdateDto rol)
        {
            TblRol objRol = new TblRol
            {
                lRol_id = rol.lRol_id,
                sRol_nm = rol.sRol_nm,
                sRol_desc = rol.sRol_desc,
                sRol_estado = rol.sRol_estado
            };
            await _tblRolRepository.Actualizar(objRol);
        }

        public async Task Crear(TblRolCreateDto rol)
        {
            TblRol objRol = new TblRol
            {
                sRol_nm = rol.sRol_nm,
                sRol_desc = rol.sRol_desc
            };
            await _tblRolRepository.Crear(objRol);
        }

        public async Task Eliminar(int idRol)
        {
            await _tblRolRepository.Eliminar(idRol);
        }

        public async Task<TblRolReadDto> ObtenerPorId(int idRol)
        {
            var result = await _tblRolRepository.ObtenerPorId(idRol);
            if (result is null) return null;
            return new TblRolReadDto
            {
                lRol_id = result.lRol_id,
                sRol_nm = result.sRol_nm,
                sRol_desc = result.sRol_desc,
                sRol_estado = result.sRol_estado
            };
        }

        public async Task<List<TblRolReadDto>> ObtenerTodos()
        {
            var roles = await _tblRolRepository.ObtenerTodos();
            var rolesDTO = new List<TblRolReadDto>();

            foreach (var rol in roles)
            {
                var rolDTO = new TblRolReadDto
                {
                    lRol_id = rol.lRol_id,
                    sRol_nm = rol.sRol_nm,
                    sRol_desc = rol.sRol_desc,
                    sRol_estado = rol.sRol_estado
                };
                rolesDTO.Add(rolDTO);
            }

            return rolesDTO;
        }
    }
}