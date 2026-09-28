using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblDocente
{
    public class TblDocenteReadDto
    {
        public int lDocente_id { get; set; }
        public string sDocente_codigo { get; set; }
        public string sDocente_correo_docente { get; set; }
        public int lPersona_id { get; set; }
    }
}
