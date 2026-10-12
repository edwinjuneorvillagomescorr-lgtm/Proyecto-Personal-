using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblAdquisicion
    {
        public int lAdquisicion_id { get; set; }
        public string sAdquisicion_NumFact { get; set; }
        public decimal sAdquisicion_costo_total { get; set; }
        public DateTime sAdquisicion_fecAdq { get; set; }
    }
}