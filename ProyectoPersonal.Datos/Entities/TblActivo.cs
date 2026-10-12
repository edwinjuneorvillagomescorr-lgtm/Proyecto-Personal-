using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblActivo
    {
        public int lActivo_id { get; set; }
        public string sActivo_nm { get; set; }
        public string sActivo_CodUnico { get; set; }
        public DateTime sActivo_fecha_registro { get; set; }
        public bool sActivo_Estado { get; set; }
        public int lEspacio_id { get; set; }
        public int lCategoria_id { get; set; }
        public int lProducto_id { get; set; }
    }
}