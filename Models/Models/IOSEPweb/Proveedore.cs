using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            FarEncabezadoCompras = new HashSet<FarEncabezadoCompra>();
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string? NombreFantasia { get; set; }
        public string? Cbu { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Domicilio { get; set; }
        public short? IdProvincia { get; set; }
        public int? IdPais { get; set; }
        public string? Cuit { get; set; }
        public short IdCondicion { get; set; }
        public string? Gnl { get; set; }
        public string? Responsable { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<FarEncabezadoCompra> FarEncabezadoCompras { get; set; }
    }
}
