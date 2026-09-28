using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblUsuario
{
    public class TblUsuarioCreateDto
    {
        public string sUsuario_nm { get; set; }
        public string sUsuario_contraseña { get; set; }
        public int lRol_id { get; set; }
        public int lPersona_id { get; set; }
    }
}
