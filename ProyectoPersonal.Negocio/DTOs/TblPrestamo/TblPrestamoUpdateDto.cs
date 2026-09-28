using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblPrestamo
{
    public class TblPrestamoUpdateDto
    {
        public int lPrestamo_id { get; set; }
        public DateTime sPrestamo_fecha_salida { get; set; }
        public DateTime sPrestamo_fecha_limite { get; set; }
        public DateTime? sPrestamo_fecha_devolucion { get; set; }
        public bool sPrestamo_estado { get; set; }
        public string sPrestamo_desc { get; set; }
        public string sPersona_tipo { get; set; }
        public int lPersona_id { get; set; }
        public int lSolicitante_id { get; set; }
    }
}
