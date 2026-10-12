using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblResponsable
    {
        public int lAdministrativo_id { get; set; }
        public string sResponsable_desc { get; set; }
        public bool sResponsable_estado { get; set; }
        public int? lActivo_id { get; set; }
    }
}