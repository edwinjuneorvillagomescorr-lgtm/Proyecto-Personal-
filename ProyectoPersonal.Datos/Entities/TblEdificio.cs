using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblEdificio
    {
        public int lEdificio_id { get; set; }
        public string sEdificio_nm { get; set; }
        public decimal sEdificio_cantidad_pisos { get; set; }
        public bool sEdificio_estado { get; set; }
        public int lArea_id { get; set; }
    }
}