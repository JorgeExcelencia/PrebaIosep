namespace ApiIosep.Models.Persona.Geo
{
    public class Localidad
    {
        public string id { get; set; } = string.Empty;
        public string nombre { get; set; } = string.Empty;
        public string categoria { get; set; } = string.Empty;
        public string Fuente { get; set; } = string.Empty;
        public datos municipio { get; set; } = new();
        public datos departamento { get; set; } = new();
        public datos provincia { get; set; } = new();
        public datos localidad_censal { get; set; } = new();
        public geopos centroide { get; set; } = new();
    }

    public class Localidades
    {
        public IEnumerable<Localidad>? localidades { get; set; }
        public int total { get; set; }
        public int cantidad { get; set; }
        public int inicio { get; set; }
    }
}
