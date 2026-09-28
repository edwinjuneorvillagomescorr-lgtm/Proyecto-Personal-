using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblProgramRepository : ITblProgramRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblProgramRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblProgram program)
        {
            IEnumerable<int> programResult = await _database.GetData<int>("fn_tblprogram_actualizar", new
            {
                p_lProgram_id = program.lProgram_id,
                p_sProgram_nm = program.sProgram_nm,
                p_sProgram_desc = program.sProgram_desc
            });
        }

        public async Task Crear(TblProgram program)
        {
            IEnumerable<int> programResult = await _database.GetData<int>("fn_tblprogram_crear", new
            {
                p_sProgram_nm = program.sProgram_nm,
                p_sProgram_desc = program.sProgram_desc
            });
        }

        public async Task Eliminar(int idProgram)
        {
            IEnumerable<int> programResult = await _database.GetData<int>("fn_tblprogram_eliminar", new
            {
                p_lProgram_id = idProgram
            });
        }

        public async Task<TblProgram> ObtenerPorId(int idProgram)
        {
            IEnumerable<TblProgram> programResult = await _database.GetData<TblProgram>("fn_tblprogram_obtenerporid", new
            {
                p_lProgram_id = idProgram
            });
            return programResult.FirstOrDefault();
        }

        public async Task<List<TblProgram>> ObtenerTodos()
        {
            IEnumerable<TblProgram> programResult = await _database.GetData<TblProgram>("fn_tblprogram_obtenertodos");
            return programResult.ToList();
        }
    }
}
