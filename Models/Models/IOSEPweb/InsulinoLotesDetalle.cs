using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InsulinoLotesDetalle
    {
        public int IdDetalle { get; set; }
        public int EncabezadoId { get; set; }
        public string Codigo { get; set; } = null!;
        public string AfiliadoCuil { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string MatriculaMedico { get; set; } = null!;
        public string? NombreMedico { get; set; }
        public string CodigoIosep { get; set; } = null!;
        public int Cantidad { get; set; }
        public string Monodroga { get; set; } = null!;
        public string NombreComercial { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string Troquel { get; set; } = null!;
        public int Coseguro { get; set; }
        public decimal Precio { get; set; }
        public decimal ImporteCoseguroAfiliado { get; set; }
        public string? CodFarmacia { get; set; }
        public string? NombreFarmacia { get; set; }
        public bool Facturado { get; set; }
        public bool Anulado { get; set; }
    }
}
