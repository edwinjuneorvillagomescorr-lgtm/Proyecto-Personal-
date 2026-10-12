using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblUsuario
    {
        public int lUsuario_id { get; set; }
        public string sUsuario_nm { get; set; }
        public string sUsuario_contraseña { get; set; }
        public bool sUsuario_estado { get; set; }
        public int lRol_id { get; set; }
        public int lPersona_id { get; set; }
    }
}
