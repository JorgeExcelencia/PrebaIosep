using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwHistorialOrdenes1
    {
        public int IdOrden { get; set; }
        public int? IdAfiliado { get; set; }
        public string Plan { get; set; } = null!;
        public byte Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string? Practica { get; set; }
        public string? NombrePractica { get; set; }
        public byte IdLugar { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime Fecha_Emision { get; set; }
        public string? Numero { get; set; }
        public int? Expr1 { get; set; }
    }
}
