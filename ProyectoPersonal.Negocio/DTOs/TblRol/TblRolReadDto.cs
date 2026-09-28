using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblRol
{
    public class TblRolReadDto
    {
        public int lRol_id { get; set; }
        public string sRol_nm { get; set; }
        public string sRol_desc { get; set; }
        public bool sRol_estado { get; set; }
    }
}
