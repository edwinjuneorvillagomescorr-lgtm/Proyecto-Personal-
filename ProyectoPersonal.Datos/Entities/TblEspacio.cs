using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblEspacio
    {
        public int lEspacio_id { get; set; }
        public string sEspacio_nm { get; set; }
        public string sEspacio_tipo { get; set; }
        public decimal sEspacio_capacidad { get; set; }
        public bool sEspacio_estado { get; set; }
        public int lEdificio_id { get; set; }
    }
}