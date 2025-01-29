using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Reintegros_Encabezado
    {
        public Reintegros_Encabezado()
        {
            Reintegro_DetalleFacturas = new HashSet<Reintegro_DetalleFactura>();
        }

        public int ReintegrosEncabezadoID { get; set; }
        public int TipoReintegroID { get; set; }
        public int? IdPrestador { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdAfiliado { get; set; }
        public int? IdTitular { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaExpediente { get; set; }
        public string Numero_Expediente { get; set; } = null!;
        public string Resumen { get; set; } = null!;
        public string? Numero_Resolucion { get; set; }
        public DateTime? Informado { get; set; }
        public string? Usuario_Informa { get; set; }
        public DateTime? Liquidado { get; set; }
        public string? Usuario_Liquida { get; set; }
        public DateTime? Cheque_Emitido { get; set; }
        public string? Usuario_Emite { get; set; }
        public string? Numero_Cheque { get; set; }
        public decimal? Importe_Cheque { get; set; }
        public DateTime? Cheque_Entregado { get; set; }
        public string? Usuario_Entrega { get; set; }
        public DateTime? Cheque_Cobrado { get; set; }
        public DateTime? Liquidado_Prestador { get; set; }
        public bool Anulado { get; set; }
        public string Usuario_Crea { get; set; } = null!;
        public string? NotasAuditoria { get; set; }
        public DateTime? AAuditoria { get; set; }
        public string? CuilChequeANomDe { get; set; }
        public string? ApellidoChequeANomDe { get; set; }
        public string? NombreChequeANomDe { get; set; }
        public bool Internado { get; set; }
        public DateTime? AGerencia { get; set; }
        public string? Usuario_Gerencia { get; set; }
        public DateTime? FinGerencia { get; set; }
        public bool Art { get; set; }
        public bool Accidente_Trabajo { get; set; }
        public int IdPlan { get; set; }
        public string Referencia_Expediente { get; set; } = null!;
        public DateTime? Fecha_Modificacion { get; set; }
        public string? Motivos_Modificacion { get; set; }
        public string? Usuario_Modif { get; set; }
        public bool Vuelve_Auditoria { get; set; }
        public bool AuditoriaGerencia { get; set; }
        public DateTime? AAuditoriaGerencia { get; set; }
        public bool Auditado { get; set; }
        public int? NroTransferencia { get; set; }
        public decimal? MontoTransferencia { get; set; }
        public DateTime? FechaTransferencia { get; set; }
        public string? EstadoDev { get; set; }
        public string? MotivoAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Archivado { get; set; }
        public string? MotivoArchiva { get; set; }
        public string? UsuarioArchiva { get; set; }
        public DateTime? FechaArchiva { get; set; }
        public bool OrdenPago { get; set; }

        public virtual Tipo_Reintegro TipoReintegro { get; set; } = null!;
        public virtual ICollection<Reintegro_DetalleFactura> Reintegro_DetalleFacturas { get; set; }
    }
}
