using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblDetalle_adquisicion
{
    public class TblDetalle_adquisicionReadDto
    {
        public int lDetalle_adquisicion_id { get; set; }
        public string sDetalle_adquisicion_Cantidad { get; set; }
        public int lAdquisicion_id { get; set; }
        public int lProducto_id { get; set; }
    }
}