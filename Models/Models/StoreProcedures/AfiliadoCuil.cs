using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Models.StoreProcedures
{
    [Keyless]
    public class AfiliadoCuil
    {
        public int IdAfiliado { get; set; }
        public string? Cuil { get; set; }
        public string? NumeroAfiliado { get; set; }
        public string? NombreAfiliado { get; set; }
        public decimal ValorCuota { get; set; }
        public string? CuilTitular { get; set; }
        public int Edad { get; set; }
        public bool edit { get; set; }
        public bool anulado { get; set; }
        public string? TipoFamiliar { get; set; }
        public int IdTipoFamiliar { get; set; }
    }
}
