using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblPrestamo_activo
    {
        public int lPrestamo_activo_id { get; set; }
        public string sPrestamo_activo_estado_del_Activo_en_su_momento { get; set; }
        public string sPrestamo_activo_estado_de_Activo_devuelto_salida { get; set; }
        public int lPrestamo_id { get; set; }
        public int lActivo_id { get; set; }
    }
}
