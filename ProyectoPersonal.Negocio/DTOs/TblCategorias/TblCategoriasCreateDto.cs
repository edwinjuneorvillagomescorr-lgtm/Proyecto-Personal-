using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblCategorias
{
    public class TblCategoriasCreateDto
    {
        public string sCategoria_nm { get; set; }
        public string sCategoria_desc { get; set; }
        public bool sCategoria_estado { get; set; }
    }
}