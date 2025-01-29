using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            NotaPedido_Presupuestos = new HashSet<NotaPedido_Presupuesto>();
            NotaPedido_Proveedores = new HashSet<NotaPedido_Proveedore>();
        }

        public int ProveedorID { get; set; }
        public string? Nombre { get; set; }
        public string? CUIT { get; set; }
        public string? Ingresos_Brutos { get; set; }
        public string? CBU { get; set; }
        public string? Domicilio { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Contacto { get; set; }
        public string? Nombre_Fantasia { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<NotaPedido_Presupuesto> NotaPedido_Presupuestos { get; set; }
        public virtual ICollection<NotaPedido_Proveedore> NotaPedido_Proveedores { get; set; }
    }
}
