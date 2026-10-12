using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblEstudiante
    {
        public int lEstudiante_id { get; set; }
        public string sEstudiante_Carrera { get; set; }
        public string sEstudiante_Registro { get; set; }
        public int lPersona_id { get; set; }
    }
}
