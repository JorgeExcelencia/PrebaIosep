using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Cuentas_Contable
    {
        public Cuentas_Contable()
        {
            AsientosModelos = new HashSet<AsientosModelo>();
            Contable_Gastos = new HashSet<Contable_Gasto>();
            Contable_Recursos = new HashSet<Contable_Recurso>();
            Encabezado_AsientoModelos = new HashSet<Encabezado_AsientoModelo>();
            NotaPedido_Encabezados = new HashSet<NotaPedido_Encabezado>();
            OrdenCompra_Encabezados = new HashSet<OrdenCompra_Encabezado>();
        }

        public int CuentaContableId { get; set; }
        public string Codigo { get; set; } = null!;
        public int TipoCuentaContableId { get; set; }
        public int SumarizaId { get; set; }
        public byte Nivel { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Observaciones { get; set; }
        public bool Anulada { get; set; }
        public bool Imputable { get; set; }
        public string Cod_Referencia { get; set; } = null!;

        public virtual Tipo_CuentaContable TipoCuentaContable { get; set; } = null!;
        public virtual ICollection<AsientosModelo> AsientosModelos { get; set; }
        public virtual ICollection<Contable_Gasto> Contable_Gastos { get; set; }
        public virtual ICollection<Contable_Recurso> Contable_Recursos { get; set; }
        public virtual ICollection<Encabezado_AsientoModelo> Encabezado_AsientoModelos { get; set; }
        public virtual ICollection<NotaPedido_Encabezado> NotaPedido_Encabezados { get; set; }
        public virtual ICollection<OrdenCompra_Encabezado> OrdenCompra_Encabezados { get; set; }
    }
}
