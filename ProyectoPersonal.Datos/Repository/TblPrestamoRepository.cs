using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Repository
{
    public class TblPrestamoRepository : ITblPrestamoRepository
    {
        private readonly ProyectoPersonalDataBase _database;
        public TblPrestamoRepository(ProyectoPersonalDataBase database)
        {
            _database = database;
        }

        public async Task Actualizar(TblPrestamo prestamo)
        {
            IEnumerable<int> prestamoResult = await _database.GetData<int>("fn_tblprestamo_actualizar", new
            {
                p_lPrestamo_id = prestamo.lPrestamo_id,
                p_sPrestamo_fecha_salida = prestamo.sPrestamo_fecha_salida,
                p_sPrestamo_fecha_limite = prestamo.sPrestamo_fecha_limite,
                p_sPrestamo_fecha_devolucion = prestamo.sPrestamo_fecha_devolucion,
                p_sPrestamo_estado = prestamo.sPrestamo_estado,
                p_sPrestamo_desc = prestamo.sPrestamo_desc,
                p_sPersona_tipo = prestamo.sPersona_tipo,
                p_lPersona_id = prestamo.lPersona_id,
                p_lSolicitante_id = prestamo.lSolicitante_id
            });
        }

        public async Task Crear(TblPrestamo prestamo)
        {
            IEnumerable<int> prestamoResult = await _database.GetData<int>("fn_tblprestamo_crear", new
            {
                p_sPrestamo_fecha_salida = prestamo.sPrestamo_fecha_salida,
                p_sPrestamo_fecha_limite = prestamo.sPrestamo_fecha_limite,
                p_sPrestamo_estado = prestamo.sPrestamo_estado,
                p_sPrestamo_desc = prestamo.sPrestamo_desc,
                p_sPersona_tipo = prestamo.sPersona_tipo,
                p_lPersona_id = prestamo.lPersona_id,
                p_lSolicitante_id = prestamo.lSolicitante_id
            });
        }

        public async Task Eliminar(int idPrestamo)
        {
            IEnumerable<int> prestamoResult = await _database.GetData<int>("fn_tblprestamo_eliminar", new
            {
                p_lPrestamo_id = idPrestamo
            });
        }

        public async Task<TblPrestamo> ObtenerPorId(int idPrestamo)
        {
            IEnumerable<TblPrestamo> prestamoResult = await _database.GetData<TblPrestamo>("fn_tblprestamo_obtenerporid", new
            {
                p_lPrestamo_id = idPrestamo
            });
            return prestamoResult.FirstOrDefault();
        }

        public async Task<List<TblPrestamo>> ObtenerTodos()
        {
            IEnumerable<TblPrestamo> prestamoResult = await _database.GetData<TblPrestamo>("fn_tblprestamo_obtenertodos");
            return prestamoResult.ToList();
        }
    }
}
