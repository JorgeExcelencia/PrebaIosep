using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PresupuestosDetalle
    {
        public int IdPresupuestoDetalle { get; set; }
        public int IdPresupuesto { get; set; }
        public int IdNomenclador { get; set; }
        public string CodigoPractica { get; set; } = null!;
        public string NombrePractica { get; set; } = null!;
        public decimal TotalCoseguro { get; set; }
        public decimal TotalIosep { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
        public bool Anulado { get; set; }
        public decimal Auditor_Porcentaje { get; set; }
        public string Tipo { get; set; } = null!;
        public int Dias { get; set; }
        public int IdAutoriza { get; set; }
        /// <summary>
        /// 0 = vacio 1 = Practica 2= Medicamentos
        /// </summary>
        public int TipoIdAutoriza { get; set; }
        public DateTime Fecha_Prescripcion { get; set; }
    }
}
