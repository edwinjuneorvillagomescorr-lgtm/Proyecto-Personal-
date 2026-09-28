using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblPrestamo_activo
{
    public class TblPrestamo_activoUpdateDto
    {
        public int lPrestamo_activo_id { get; set; }
        public string sPrestamo_activo_estado_del_Activo_en_su_momento { get; set; }
        public string sPrestamo_activo_estado_de_Activo_devuelto_salida { get; set; }
        public int lPrestamo_id { get; set; }
        public int lActivo_id { get; set; }
    }
}
