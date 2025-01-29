using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NPracticas_Base
    {
        public NPracticas_Base()
        {
            DetallePreBonos = new HashSet<DetallePreBono>();
            GrupoDetallePracticas = new HashSet<GrupoDetallePractica>();
            NNomenclador_Bases = new HashSet<NNomenclador_Base>();
            PracticaTurnos = new HashSet<PracticaTurno>();
        }

        public int IdPractica_Base { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int? IdTipo_Practica { get; set; }
        public int IdSexo { get; set; }
        public int? IdCapitulo { get; set; }
        public int? IdSubCapitulo { get; set; }
        public decimal? Unidad_Especialista { get; set; }
        public decimal? Unidad_Anestesista { get; set; }
        public byte? Numero_ayudantes { get; set; }
        public decimal? Unidad_Ayudante1 { get; set; }
        public decimal? Unidad_Ayudante2 { get; set; }
        public decimal? Unidad_Ayudante3 { get; set; }
        public decimal? Unidad_Ayudante4 { get; set; }
        public decimal? Unidad_Instrumentista { get; set; }
        public decimal? Unidad_Gastos { get; set; }
        public decimal? Unidad_Honorarios { get; set; }
        public int? IdUnidad_Honorarios { get; set; }
        public int? IdUnidad_Gastos { get; set; }
        public string? Descripcion_Practica { get; set; }
        public string? Descripcion_Normas { get; set; }
        public bool Activo { get; set; }
        public bool? Anulado { get; set; }
        public int? TopeMensual { get; set; }
        public string? NoNomenclada { get; set; }

        public virtual NomSubCapitulo? IdSubCapituloNavigation { get; set; }
        public virtual TipoPractica? IdTipo_PracticaNavigation { get; set; }
        public virtual PracticasDelegacion? PracticasDelegacion { get; set; }
        public virtual ICollection<DetallePreBono> DetallePreBonos { get; set; }
        public virtual ICollection<GrupoDetallePractica> GrupoDetallePracticas { get; set; }
        public virtual ICollection<NNomenclador_Base> NNomenclador_Bases { get; set; }
        public virtual ICollection<PracticaTurno> PracticaTurnos { get; set; }
    }
}
