using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblPersona
{
    public class TblPersonaReadDto
    {
        public int lPersona_id { get; set; }
        public string sPersona_nm { get; set; }
        public string sPersona_apellido { get; set; }
        public string sPersona_correo { get; set; }
        public string sPersona_CI { get; set; }
        public bool sPersona_Estado { get; set; }
    }
}
