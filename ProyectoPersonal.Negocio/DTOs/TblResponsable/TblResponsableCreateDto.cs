using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblResponsable
{
    public class TblResponsableCreateDto
    {
        public int lAdministrativo_id { get; set; }
        public string sResponsable_desc { get; set; }
        public bool sResponsable_estado { get; set; }
        public int? lActivo_id { get; set; }
    }
}