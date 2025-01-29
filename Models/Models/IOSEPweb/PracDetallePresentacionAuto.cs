using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PracDetallePresentacionAuto
    {
        public PracDetallePresentacionAuto()
        {
            PracDetalleOrdenAutos = new HashSet<PracDetalleOrdenAuto>();
        }

        public int IdDetallePresentacionAuto { get; set; }
        public int EncabezadoId { get; set; }
        public int IdPrestador { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime FechaPractica { get; set; }
        public int IdAfiliado { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public int IdCentroOriginal { get; set; }
        public int IdCentroImpreso { get; set; }
        public int IdGrupoPractica { get; set; }
        public bool Credito { get; set; }
        public bool SugiereDebito { get; set; }
        public bool Chequeado { get; set; }
        public int IdInternado { get; set; }
        public bool ACompartida { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual PracEncabezadoPresentacion Encabezado { get; set; } = null!;
        public virtual ICollection<PracDetalleOrdenAuto> PracDetalleOrdenAutos { get; set; }
    }
}
