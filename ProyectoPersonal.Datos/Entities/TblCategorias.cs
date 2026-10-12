using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblCategorias
    {
        public int lCategoria_id { get; set; }
        public string sCategoria_nm { get; set; }
        public string sCategoria_desc { get; set; }
        public bool sCategoria_estado { get; set; }
    }
}