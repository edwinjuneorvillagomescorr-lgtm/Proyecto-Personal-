using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Negocio.DTOs.TblTransferencia_activo
{
    public class TblTransferencia_activoReadDto
    {
        public int lTransferencia_activo_id { get; set; }
        public string sTransferencia_activo_nm { get; set; }
        public string sTransferencia_activo_origen { get; set; }
        public string sTransferencia_activo_destino { get; set; }
        public string sTransferencia_activo_responsable { get; set; }
        public DateTime sTransferencia_activo_fecha { get; set; }
        public bool sTransferencia_activo_estado { get; set; }
        public int lActivo_id { get; set; }
        public int lEspacio_origen_id { get; set; }
        public int lEspacio_destino_id { get; set; }
        public int lPersona_id { get; set; }
    }
}
