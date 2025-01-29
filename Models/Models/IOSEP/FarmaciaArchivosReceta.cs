using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class FarmaciaArchivosReceta
    {
        public int IdFarmaciaArchivosReceta { get; set; }
        public int IdFarmaciaArchivos { get; set; }
        public int NroNodo { get; set; }
        public string NroAutorizacion { get; set; } = null!;
        public int IdFarmacia { get; set; }
        public string NombreFarmacia { get; set; } = null!;
        public DateTime FechaPrescripcion { get; set; }
        public DateTime FechaVenta { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public bool Autorizada { get; set; }
        public string NroReceta { get; set; } = null!;
        public string NroAfiliado { get; set; } = null!;
        public string TipoMatricula { get; set; } = null!;
        public int Matricula { get; set; }
        public decimal ImporteReceta { get; set; }
        public decimal ImporteObraSocial { get; set; }
        public decimal ImporteAfiliado { get; set; }
        public int CodRechazo { get; set; }
        public string MotivoRechazo { get; set; } = null!;
        public int Renglon { get; set; }
        public string CodigoAlfabeta { get; set; } = null!;
        public string Troquel { get; set; } = null!;
        public string CogidoBarra { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal PrecioVentaPublico { get; set; }
        public decimal PrecioReferenciaObraSocial { get; set; }
        public decimal ImporteRenglon { get; set; }
        public decimal ImporteObraSocialRenglon { get; set; }
        public decimal ImporteAfiliadoRenglon { get; set; }
        public int CodRechazoRenglon { get; set; }
        public string MotivoRechazoRenglon { get; set; } = null!;
        public int IdPlan { get; set; }
        public string NombrePlan { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public bool IncluidaRecupero { get; set; }
        public int? ReporteRecuperoID { get; set; }
    }
}
