using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblAdquisicion
{
    public class TblAdquisicionCreateDto
    {
        public string sAdquisicion_NumFact { get; set; }
        public decimal sAdquisicion_costo_total { get; set; }
        public DateTime sAdquisicion_fecAdq { get; set; }
    }
}