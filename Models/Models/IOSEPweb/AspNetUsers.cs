using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AspNetUser1
    {
        public AspNetUser1()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            Roles = new HashSet<AspNetRole1>();
        }

        public string Id { get; set; } = null!;
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; } = null!;
        public string? Name { get; set; }
        public string? Sucursal { get; set; }
        public bool? AtiendeTurnos { get; set; }
        public string? FarSucursales { get; set; }
        public string? Alias { get; set; }
        public int IdDigitalizar { get; set; }
        public string? Token { get; set; }
        public bool? TerminosCondiciones { get; set; }
        public DateTime? FechaAcepta { get; set; }
        public bool? RequiereCambioClave { get; set; }
        public string? OperadorActualiza { get; set; }
        public bool? Deshabilitado { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

        public virtual ICollection<AspNetRole1> Roles { get; set; }
    }
}
