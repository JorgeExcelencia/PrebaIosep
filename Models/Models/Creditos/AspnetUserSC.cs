using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models.Creditos
{
    [NotMapped]
    public partial class AspnetUserSC
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string? PasswordHash { get; set; }
        public string UserName { get; set; } = null!;
        public string Name { get; set; }
        public bool Deshabilitado { get; set; }
    }
}
