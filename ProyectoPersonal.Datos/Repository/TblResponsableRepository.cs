using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblResponsableRepository : ITblResponsableRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblResponsableRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblResponsable responsable)
        {
            IEnumerable<int> responsableResult = await _database.GetData<int>("fn_tblresponsable_actualizar", new
            {
                p_lAdministrativo_id = responsable.lAdministrativo_id,
                p_sResponsable_desc = responsable.sResponsable_desc,
                p_sResponsable_estado = responsable.sResponsable_estado,
                p_lActivo_id = responsable.lActivo_id
            });
        }

        public async Task Crear(TblResponsable responsable)
        {
            IEnumerable<int> responsableResult = await _database.GetData<int>("fn_tblresponsable_crear", new
            {
                p_lAdministrativo_id = responsable.lAdministrativo_id,
                p_sResponsable_desc = responsable.sResponsable_desc,
                p_sResponsable_estado = responsable.sResponsable_estado,
                p_lActivo_id = responsable.lActivo_id
            });
        }

        public async Task Eliminar(int idAdministrativo)
        {
            IEnumerable<int> responsableResult = await _database.GetData<int>("fn_tblresponsable_eliminar", new
            {
                p_lAdministrativo_id = idAdministrativo
            });
        }

        public async Task<TblResponsable> ObtenerPorId(int idAdministrativo)
        {
            IEnumerable<TblResponsable> responsableResult = await _database.GetData<TblResponsable>("fn_tblresponsable_obtenerporid", new
            {
                p_lAdministrativo_id = idAdministrativo
            });
            return responsableResult.FirstOrDefault();
        }

        public async Task<List<TblResponsable>> ObtenerTodos()
        {
            IEnumerable<TblResponsable> responsableResult = await _database.GetData<TblResponsable>("fn_tblresponsable_obtenertodos");
            return responsableResult.ToList();
        }
    }
}