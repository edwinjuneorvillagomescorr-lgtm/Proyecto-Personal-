using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblProgram;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblProgramService : ITblProgramService
    {
        private readonly ITblProgramRepository _tblProgramRepository;
        public TblProgramService(ITblProgramRepository tblProgramRepository)
        {
            _tblProgramRepository = tblProgramRepository;
        }

        public async Task Actualizar(TblProgramUpdateDto program)
        {
            TblProgram objProgram = new TblProgram
            {
                lProgram_id = program.lProgram_id,
                sProgram_nm = program.sProgram_nm,
                sProgram_desc = program.sProgram_desc
            };
            await _tblProgramRepository.Actualizar(objProgram);
        }

        public async Task Crear(TblProgramCreateDto program)
        {
            TblProgram objProgram = new TblProgram
            {
                sProgram_nm = program.sProgram_nm,
                sProgram_desc = program.sProgram_desc
            };
            await _tblProgramRepository.Crear(objProgram);
        }

        public async Task Eliminar(int idProgram)
        {
            await _tblProgramRepository.Eliminar(idProgram);
        }

        public async Task<TblProgramReadDto> ObtenerPorId(int idProgram)
        {
            var result = await _tblProgramRepository.ObtenerPorId(idProgram);
            if (result is null) return null;
            return new TblProgramReadDto
            {
                lProgram_id = result.lProgram_id,
                sProgram_nm = result.sProgram_nm,
                sProgram_desc = result.sProgram_desc
            };
        }

        public async Task<List<TblProgramReadDto>> ObtenerTodos()
        {
            var programs = await _tblProgramRepository.ObtenerTodos();
            var programsDTO = new List<TblProgramReadDto>();

            foreach (var program in programs)
            {
                var programDTO = new TblProgramReadDto
                {
                    lProgram_id = program.lProgram_id,
                    sProgram_nm = program.sProgram_nm,
                    sProgram_desc = program.sProgram_desc
                };
                programsDTO.Add(programDTO);
            }

            return programsDTO;
        }
    }
}