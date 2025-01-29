using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class EncabezadoPresentacionFarmacium
    {
        public EncabezadoPresentacionFarmacium()
        {
            FarEncabezadoPresentacions = new HashSet<FarEncabezadoPresentacion>();
        }

        public int EncabezadoId { get; set; }
        public string? CiuInstitucion { get; set; }
        public string? NombreInstitucion { get; set; }
        public string? PeriodoPresentacion { get; set; }
        public string? ConceptoPresentacion { get; set; }
        public bool? IosepSalud { get; set; }
        public decimal? ImportePresentado { get; set; }
        public decimal? CoseguroPresentado { get; set; }
        public decimal? Debitado { get; set; }
        public int? CantidadRegistros { get; set; }
        public int? RegistrosCorrectos { get; set; }
        public int? RegistrosFallidos { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaSubida { get; set; }
        public string? User { get; set; }
        public DateTime? Cerrado { get; set; }
        public string? OperadorCierra { get; set; }
        public string? NumFactura { get; set; }
        public DateTime? FechaCierreAuditoria { get; set; }
        public string? OperadorCierreAuditoria { get; set; }

        public virtual ICollection<FarEncabezadoPresentacion> FarEncabezadoPresentacions { get; set; }
    }
}
