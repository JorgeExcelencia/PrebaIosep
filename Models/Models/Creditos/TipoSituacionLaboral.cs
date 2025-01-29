using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public partial class TipoSituacionLaboral
    {
        public TipoSituacionLaboral()
        {
            LugarPagoDdjjs = new HashSet<LugarPagoDdjj>();
        }
        [Key]
        public int IdSituacionLaboral { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<LugarPagoDdjj> LugarPagoDdjjs { get; set; }
    }
}
