using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblDocente;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblDocenteService : ITblDocenteService
    {
        private readonly ITblDocenteRepository _tblDocenteRepository;
        public TblDocenteService(ITblDocenteRepository tblDocenteRepository)
        {
            _tblDocenteRepository = tblDocenteRepository;
        }

        public async Task Actualizar(TblDocenteUpdateDto docente)
        {
            TblDocente objDocente = new TblDocente
            {
                lDocente_id = docente.lDocente_id,
                sDocente_codigo = docente.sDocente_codigo,
                sDocente_correo_docente = docente.sDocente_correo_docente,
                lPersona_id = docente.lPersona_id
            };
            await _tblDocenteRepository.Actualizar(objDocente);
        }

        public async Task Crear(TblDocenteCreateDto docente)
        {
            TblDocente objDocente = new TblDocente
            {
                sDocente_codigo = docente.sDocente_codigo,
                sDocente_correo_docente = docente.sDocente_correo_docente,
                lPersona_id = docente.lPersona_id
            };
            await _tblDocenteRepository.Crear(objDocente);
        }

        public async Task Eliminar(int idDocente)
        {
            await _tblDocenteRepository.Eliminar(idDocente);
        }

        public async Task<TblDocenteReadDto> ObtenerPorId(int idDocente)
        {
            var result = await _tblDocenteRepository.ObtenerPorId(idDocente);
            if (result is null) return null;
            return new TblDocenteReadDto
            {
                lDocente_id = result.lDocente_id,
                sDocente_codigo = result.sDocente_codigo,
                sDocente_correo_docente = result.sDocente_correo_docente,
                lPersona_id = result.lPersona_id
            };
        }

        public async Task<List<TblDocenteReadDto>> ObtenerTodos()
        {
            var docentes = await _tblDocenteRepository.ObtenerTodos();
            var docentesDTO = new List<TblDocenteReadDto>();

            foreach (var docente in docentes)
            {
                var docenteDTO = new TblDocenteReadDto
                {
                    lDocente_id = docente.lDocente_id,
                    sDocente_codigo = docente.sDocente_codigo,
                    sDocente_correo_docente = docente.sDocente_correo_docente,
                    lPersona_id = docente.lPersona_id
                };
                docentesDTO.Add(docenteDTO);
            }

            return docentesDTO;
        }
    }
}