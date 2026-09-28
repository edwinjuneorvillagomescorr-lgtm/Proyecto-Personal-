using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblPermisos;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblPermisosService : ITblPermisosService
    {
        private readonly ITblPermisosRepository _tblPermisosRepository;
        public TblPermisosService(ITblPermisosRepository tblPermisosRepository)
        {
            _tblPermisosRepository = tblPermisosRepository;
        }

        public async Task Actualizar(TblPermisosUpdateDto permisos)
        {
            TblPermisos objPermisos = new TblPermisos
            {
                lPermisos_id = permisos.lPermisos_id,
                Insertar = permisos.Insertar,
                Consultar = permisos.Consultar,
                Actualizar = permisos.Actualizar,
                Eliminar = permisos.Eliminar,
                lRol_id = permisos.lRol_id,
                lProgram_id = permisos.lProgram_id
            };
            await _tblPermisosRepository.Actualizar(objPermisos);
        }

        public async Task Crear(TblPermisosCreateDto permisos)
        {
            TblPermisos objPermisos = new TblPermisos
            {
                Insertar = permisos.Insertar,
                Consultar = permisos.Consultar,
                Actualizar = permisos.Actualizar,
                Eliminar = permisos.Eliminar,
                lRol_id = permisos.lRol_id,
                lProgram_id = permisos.lProgram_id
            };
            await _tblPermisosRepository.Crear(objPermisos);
        }

        public async Task Eliminar(int idPermisos)
        {
            await _tblPermisosRepository.Eliminar(idPermisos);
        }

        public async Task<TblPermisosReadDto> ObtenerPorId(int idPermisos)
        {
            var result = await _tblPermisosRepository.ObtenerPorId(idPermisos);
            if (result is null) return null;
            return new TblPermisosReadDto
            {
                lPermisos_id = result.lPermisos_id,
                Insertar = result.Insertar,
                Consultar = result.Consultar,
                Actualizar = result.Actualizar,
                Eliminar = result.Eliminar,
                lRol_id = result.lRol_id,
                lProgram_id = result.lProgram_id
            };
        }

        public async Task<List<TblPermisosReadDto>> ObtenerTodos()
        {
            var permisosList = await _tblPermisosRepository.ObtenerTodos();
            var permisosDTO = new List<TblPermisosReadDto>();

            foreach (var permisos in permisosList)
            {
                var permisoDTO = new TblPermisosReadDto
                {
                    lPermisos_id = permisos.lPermisos_id,
                    Insertar = permisos.Insertar,
                    Consultar = permisos.Consultar,
                    Actualizar = permisos.Actualizar,
                    Eliminar = permisos.Eliminar,
                    lRol_id = permisos.lRol_id,
                    lProgram_id = permisos.lProgram_id
                };
                permisosDTO.Add(permisoDTO);
            }

            return permisosDTO;
        }
    }
}