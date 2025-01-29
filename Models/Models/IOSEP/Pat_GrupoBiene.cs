using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Pat_GrupoBiene
    {
        public Pat_GrupoBiene()
        {
            Pat_Bienes = new HashSet<Pat_Biene>();
        }

        public int IdGrupo_Bien { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaModi { get; set; }
        public string OpModi { get; set; } = null!;

        public virtual ICollection<Pat_Biene> Pat_Bienes { get; set; }
    }
}
