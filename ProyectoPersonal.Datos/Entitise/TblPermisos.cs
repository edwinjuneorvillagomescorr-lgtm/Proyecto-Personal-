using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPersonal.Datos.Entities
{
    public class TblPermisos
    {
        public int lPermisos_id { get; set; }
        public bool Insertar { get; set; }
        public bool Consultar { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
        public int lRol_id { get; set; }
        public int lProgram_id { get; set; }
    }
}
