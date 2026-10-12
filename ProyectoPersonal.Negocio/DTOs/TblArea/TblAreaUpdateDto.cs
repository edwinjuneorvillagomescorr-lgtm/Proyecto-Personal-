using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblArea
{
    public class TblAreaUpdateDto
    {
        public int lArea_id { get; set; }
        public string sArea_nm { get; set; }
        public string sArea_Sector { get; set; }
        public string sArea_tipo { get; set; }
    }
}