using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PlanesAfiliado_Resolucion
    {
        public int IdPlanesAfiliado_Resolucion { get; set; }
        public int? IdPlanes_Afiliado { get; set; }
        public int? CartaPresentacionID { get; set; }
        public string? Resolucion { get; set; }
        public string? Ref_Resolucion { get; set; }
        public string? NroExpediente { get; set; }
        public string? Ref_Expediente { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Vencimiento { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? ModificaOperador { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }
    }
}
