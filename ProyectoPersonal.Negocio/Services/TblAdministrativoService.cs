using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblAdministrativo;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblAdministrativoService : ITblAdministrativoService
    {
        private readonly ITblAdministrativoRepository _tblAdministrativoRepository;
        public TblAdministrativoService(ITblAdministrativoRepository tblAdministrativoRepository)
        {
            _tblAdministrativoRepository = tblAdministrativoRepository;
        }

        public async Task Actualizar(TblAdministrativoUpdateDto administrativo)
        {
            TblAdministrativo objAdministrativo = new TblAdministrativo
            {
                lAdministrativo_id = administrativo.lAdministrativo_id,
                sAdministrativo_nm = administrativo.sAdministrativo_nm,
                lPersona_id = administrativo.lPersona_id
            };
            await _tblAdministrativoRepository.Actualizar(objAdministrativo);
        }

        public async Task Crear(TblAdministrativoCreateDto administrativo)
        {
            TblAdministrativo objAdministrativo = new TblAdministrativo
            {
                sAdministrativo_nm = administrativo.sAdministrativo_nm,
                lPersona_id = administrativo.lPersona_id
            };
            await _tblAdministrativoRepository.Crear(objAdministrativo);
        }

        public async Task Eliminar(int idAdministrativo)
        {
            await _tblAdministrativoRepository.Eliminar(idAdministrativo);
        }

        public async Task<TblAdministrativoReadDto> ObtenerPorId(int idAdministrativo)
        {
            var result = await _tblAdministrativoRepository.ObtenerPorId(idAdministrativo);
            if (result is null) return null;
            return new TblAdministrativoReadDto
            {
                lAdministrativo_id = result.lAdministrativo_id,
                sAdministrativo_nm = result.sAdministrativo_nm,
                lPersona_id = result.lPersona_id
            };
        }

        public async Task<List<TblAdministrativoReadDto>> ObtenerTodos()
        {
            var administrativos = await _tblAdministrativoRepository.ObtenerTodos();
            var administrativosDTO = new List<TblAdministrativoReadDto>();

            foreach (var administrativo in administrativos)
            {
                var administrativoDTO = new TblAdministrativoReadDto
                {
                    lAdministrativo_id = administrativo.lAdministrativo_id,
                    sAdministrativo_nm = administrativo.sAdministrativo_nm,
                    lPersona_id = administrativo.lPersona_id
                };
                administrativosDTO.Add(administrativoDTO);
            }

            return administrativosDTO;
        }
    }
}