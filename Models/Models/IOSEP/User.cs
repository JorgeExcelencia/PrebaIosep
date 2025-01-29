using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? Phone { get; set; }
        public bool PhoneConfirmed { get; set; }
        public string? UserID { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string? Code { get; set; }
        public string? UserRelationship { get; set; }
        public string? PasswordRelationship { get; set; }
        public int? AccessFailedCount { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastAccess { get; set; }
        public string? Sucursal { get; set; }
        public string? Roles { get; set; }
        public bool Active { get; set; }
        public string? App { get; set; }
    }
}
