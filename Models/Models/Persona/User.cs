using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.Persona
{
    [Table("User", Schema = "usuario")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool EmailConfirmed { get; set; } = false;
        public string? Phone { get; set; }
        public bool PhoneConfirmed { get; set; } = false;
        public string? UserID { get; set; }
        public string Password { get; set; } = String.Empty;
        public string? Token { get; set; }
        public bool TwoFactorEnabled { get; set; } = false;
        public string? Code { get; set; }
        public string? UserRelationship { get; set; }
        public string? PasswordRelationship { get; set; }
        public int? AccessFailedCount { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastAccess { get; set; }
        public string Sucursal { get; set; } = "0001";
        public string Roles { get; set; } = string.Empty;
        public bool Active { get; set; } = false;
        public string? App { get; set; }
    }
}
