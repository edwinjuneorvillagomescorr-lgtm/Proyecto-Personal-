using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblDetalle_adquisicion
    {
        public int lDetalle_adquisicion_id { get; set; }
        public string sDetalle_adquisicion_Cantidad { get; set; }
        public int lAdquisicion_id { get; set; }
        public int lProducto_id { get; set; }
    }
}