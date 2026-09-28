using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblEstudiante
{
    public class TblEstudianteCreateDto
    {
        public string sEstudiante_Carrera { get; set; }
        public string sEstudiante_Registro { get; set; }
        public int lPersona_id { get; set; }
    }
}
