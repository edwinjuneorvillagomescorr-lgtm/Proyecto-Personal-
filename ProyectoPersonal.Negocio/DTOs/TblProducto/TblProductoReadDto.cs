using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblProducto
{
    public class TblProductoReadDto
    {
        public int lProducto_id { get; set; }
        public string sProducto_nm { get; set; }
        public string sProducto_desc { get; set; }
        public string sProducto_numSerie { get; set; }
        public int lMarca_id { get; set; }
    }
}