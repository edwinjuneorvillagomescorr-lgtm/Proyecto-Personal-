using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblPersona
    {
        public int lPersona_id { get; set; }
        public string sPersona_nm { get; set; }
        public string sPersona_apellido { get; set; }
        public string sPersona_correo { get; set; }
        public string sPersona_CI { get; set; }
        public bool sPersona_Estado { get; set; }
    }
}
