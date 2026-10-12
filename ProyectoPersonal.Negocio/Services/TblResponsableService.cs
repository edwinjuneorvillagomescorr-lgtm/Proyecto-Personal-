using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblResponsable;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblResponsableService : ITblResponsableService
    {
        private readonly ITblResponsableRepository _tblResponsableRepository;
        public TblResponsableService(ITblResponsableRepository tblResponsableRepository)
        {
            _tblResponsableRepository = tblResponsableRepository;
        }

        public async Task Actualizar(TblResponsableUpdateDto responsable)
        {
            TblResponsable objResponsable = new TblResponsable
            {
                lAdministrativo_id = responsable.lAdministrativo_id,
                sResponsable_desc = responsable.sResponsable_desc,
                sResponsable_estado = responsable.sResponsable_estado,
                lActivo_id = responsable.lActivo_id
            };
            await _tblResponsableRepository.Actualizar(objResponsable);
        }

        public async Task Crear(TblResponsableCreateDto responsable)
        {
            TblResponsable objResponsable = new TblResponsable
            {
                lAdministrativo_id = responsable.lAdministrativo_id,
                sResponsable_desc = responsable.sResponsable_desc,
                sResponsable_estado = responsable.sResponsable_estado,
                lActivo_id = responsable.lActivo_id
            };
            await _tblResponsableRepository.Crear(objResponsable);
        }

        public async Task Eliminar(int idAdministrativo)
        {
            await _tblResponsableRepository.Eliminar(idAdministrativo);
        }

        public async Task<TblResponsableReadDto> ObtenerPorId(int idAdministrativo)
        {
            var result = await _tblResponsableRepository.ObtenerPorId(idAdministrativo);

            if (result is null) return null;

            return new TblResponsableReadDto
            {
                lAdministrativo_id = result.lAdministrativo_id,
                sResponsable_desc = result.sResponsable_desc,
                sResponsable_estado = result.sResponsable_estado,
                lActivo_id = result.lActivo_id
            };
        }

        public async Task<List<TblResponsableReadDto>> ObtenerTodos()
        {
            var responsables = await _tblResponsableRepository.ObtenerTodos();
            var responsablesDTO = new List<TblResponsableReadDto>();

            foreach (var responsable in responsables)
            {
                var responsableDTO = new TblResponsableReadDto
                {
                    lAdministrativo_id = responsable.lAdministrativo_id,
                    sResponsable_desc = responsable.sResponsable_desc,
                    sResponsable_estado = responsable.sResponsable_estado,
                    lActivo_id = responsable.lActivo_id
                };

                responsablesDTO.Add(responsableDTO);
            }

            return responsablesDTO;
        }
    }
}