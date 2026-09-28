using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblEstudiante;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblEstudianteService : ITblEstudianteService
    {
        private readonly ITblEstudianteRepository _tblEstudianteRepository;
        public TblEstudianteService(ITblEstudianteRepository tblEstudianteRepository)
        {
            _tblEstudianteRepository = tblEstudianteRepository;
        }

        public async Task Actualizar(TblEstudianteUpdateDto estudiante)
        {
            TblEstudiante objEstudiante = new TblEstudiante
            {
                lEstudiante_id = estudiante.lEstudiante_id,
                sEstudiante_Carrera = estudiante.sEstudiante_Carrera,
                sEstudiante_Registro = estudiante.sEstudiante_Registro,
                lPersona_id = estudiante.lPersona_id
            };
            await _tblEstudianteRepository.Actualizar(objEstudiante);
        }

        public async Task Crear(TblEstudianteCreateDto estudiante)
        {
            TblEstudiante objEstudiante = new TblEstudiante
            {
                sEstudiante_Carrera = estudiante.sEstudiante_Carrera,
                sEstudiante_Registro = estudiante.sEstudiante_Registro,
                lPersona_id = estudiante.lPersona_id
            };
            await _tblEstudianteRepository.Crear(objEstudiante);
        }

        public async Task Eliminar(int idEstudiante)
        {
            await _tblEstudianteRepository.Eliminar(idEstudiante);
        }

        public async Task<TblEstudianteReadDto> ObtenerPorId(int idEstudiante)
        {
            var result = await _tblEstudianteRepository.ObtenerPorId(idEstudiante);
            if (result is null) return null;
            return new TblEstudianteReadDto
            {
                lEstudiante_id = result.lEstudiante_id,
                sEstudiante_Carrera = result.sEstudiante_Carrera,
                sEstudiante_Registro = result.sEstudiante_Registro,
                lPersona_id = result.lPersona_id
            };
        }

        public async Task<List<TblEstudianteReadDto>> ObtenerTodos()
        {
            var estudiantes = await _tblEstudianteRepository.ObtenerTodos();
            var estudiantesDTO = new List<TblEstudianteReadDto>();

            foreach (var estudiante in estudiantes)
            {
                var estudianteDTO = new TblEstudianteReadDto
                {
                    lEstudiante_id = estudiante.lEstudiante_id,
                    sEstudiante_Carrera = estudiante.sEstudiante_Carrera,
                    sEstudiante_Registro = estudiante.sEstudiante_Registro,
                    lPersona_id = estudiante.lPersona_id
                };
                estudiantesDTO.Add(estudianteDTO);
            }

            return estudiantesDTO;
        }
    }
}
