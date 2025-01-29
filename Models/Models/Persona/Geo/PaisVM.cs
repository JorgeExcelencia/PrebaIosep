namespace ApiIosep.Models.Persona.Geo
{
    public class PaisVM
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Code { get; set; }
        public IEnumerable<ProvinciaVM>? Provincias { get; set; }
    }

    public class ProvinciaVM
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
