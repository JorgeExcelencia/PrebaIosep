using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AspNetRole1
    {
        public AspNetRole1()
        {
            Users = new HashSet<AspNetUser1>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Observacion { get; set; }
        public bool? Deleteable { get; set; }

        public virtual ICollection<AspNetUser1> Users { get; set; }
    }
}
