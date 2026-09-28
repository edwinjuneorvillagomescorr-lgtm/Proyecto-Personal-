using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblPrestamo_activoRepository : ITblPrestamo_activoRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblPrestamo_activoRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblPrestamo_activo prestamoActivo)
        {
            IEnumerable<int> prestamoActivoResult = await _database.GetData<int>("fn_tblprestamo_activo_actualizar", new
            {
                p_lPrestamo_activo_id = prestamoActivo.lPrestamo_activo_id,
                p_sPrestamo_activo_estado_del_Activo_en_su_momento = prestamoActivo.sPrestamo_activo_estado_del_Activo_en_su_momento,
                p_sPrestamo_activo_estado_de_Activo_devuelto_salida = prestamoActivo.sPrestamo_activo_estado_de_Activo_devuelto_salida,
                p_lPrestamo_id = prestamoActivo.lPrestamo_id,
                p_lActivo_id = prestamoActivo.lActivo_id
            });
        }

        public async Task Crear(TblPrestamo_activo prestamoActivo)
        {
            IEnumerable<int> prestamoActivoResult = await _database.GetData<int>("fn_tblprestamo_activo_crear", new
            {
                p_sPrestamo_activo_estado_del_Activo_en_su_momento = prestamoActivo.sPrestamo_activo_estado_del_Activo_en_su_momento,
                p_sPrestamo_activo_estado_de_Activo_devuelto_salida = prestamoActivo.sPrestamo_activo_estado_de_Activo_devuelto_salida,
                p_lPrestamo_id = prestamoActivo.lPrestamo_id,
                p_lActivo_id = prestamoActivo.lActivo_id
            });
        }

        public async Task Eliminar(int idPrestamoActivo)
        {
            IEnumerable<int> prestamoActivoResult = await _database.GetData<int>("fn_tblprestamo_activo_eliminar", new
            {
                p_lPrestamo_activo_id = idPrestamoActivo
            });
        }

        public async Task<TblPrestamo_activo> ObtenerPorId(int idPrestamoActivo)
        {
            IEnumerable<TblPrestamo_activo> prestamoActivoResult = await _database.GetData<TblPrestamo_activo>("fn_tblprestamo_activo_obtenerporid", new
            {
                p_lPrestamo_activo_id = idPrestamoActivo
            });
            return prestamoActivoResult.FirstOrDefault();
        }

        public async Task<List<TblPrestamo_activo>> ObtenerTodos()
        {
            IEnumerable<TblPrestamo_activo> prestamoActivoResult = await _database.GetData<TblPrestamo_activo>("fn_tblprestamo_activo_obtenertodos");
            return prestamoActivoResult.ToList();
        }
    }
}
