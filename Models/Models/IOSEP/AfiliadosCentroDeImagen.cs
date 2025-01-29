using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadosCentroDeImagen
    {
        public int IdAfiliadoCentroDeImagen { get; set; }
        public int IdCentroPorGrupo { get; set; }
        public int IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public string A_Numero { get; set; } = null!;
        public string? UsuarioCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }
        public string? MotivoAnula { get; set; }
        public bool? PedidoCambio { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
        public virtual CentrosPorGrupoPractica IdCentroPorGrupoNavigation { get; set; } = null!;
    }
}
