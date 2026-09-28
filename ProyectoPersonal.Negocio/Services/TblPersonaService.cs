using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblPersona;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblPersonaService : ITblPersonaService
    {
        private readonly ITblPersonaRepository _tblPersonaRepository;
        public TblPersonaService(ITblPersonaRepository tblPersonaRepository)
        {
            _tblPersonaRepository = tblPersonaRepository;
        }

        public async Task Actualizar(TblPersonaUpdateDto persona)
        {
            TblPersona objPersona = new TblPersona
            {
                lPersona_id = persona.lPersona_id,
                sPersona_nm = persona.sPersona_nm,
                sPersona_apellido = persona.sPersona_apellido,
                sPersona_correo = persona.sPersona_correo,
                sPersona_CI = persona.sPersona_CI
            };
            await _tblPersonaRepository.Actualizar(objPersona);
        }

        public async Task Crear(TblPersonaCreateDto persona)
        {
            TblPersona objPersona = new TblPersona
            {
                sPersona_nm = persona.sPersona_nm,
                sPersona_apellido = persona.sPersona_apellido,
                sPersona_correo = persona.sPersona_correo,
                sPersona_CI = persona.sPersona_CI
            };
            await _tblPersonaRepository.Crear(objPersona);
        }

        public async Task Eliminar(int idPersona)
        {
            await _tblPersonaRepository.Eliminar(idPersona);
        }

        public async Task<TblPersonaReadDto> ObtenerPorId(int idPersona)
        {
            var result = await _tblPersonaRepository.ObtenerPorId(idPersona);
            if (result is null) return null;
            return new TblPersonaReadDto
            {
                lPersona_id = result.lPersona_id,
                sPersona_nm = result.sPersona_nm,
                sPersona_apellido = result.sPersona_apellido,
                sPersona_correo = result.sPersona_correo,
                sPersona_CI = result.sPersona_CI
            };
        }

        public async Task<List<TblPersonaReadDto>> ObtenerTodos()
        {
            var personas = await _tblPersonaRepository.ObtenerTodos();
            var personasDTO = new List<TblPersonaReadDto>();

            foreach (var persona in personas)
            {
                var personaDTO = new TblPersonaReadDto
                {
                    lPersona_id = persona.lPersona_id,
                    sPersona_nm = persona.sPersona_nm,
                    sPersona_apellido = persona.sPersona_apellido,
                    sPersona_correo = persona.sPersona_correo,
                    sPersona_CI = persona.sPersona_CI
                };
                personasDTO.Add(personaDTO);
            }

            return personasDTO;
        }
    }
}