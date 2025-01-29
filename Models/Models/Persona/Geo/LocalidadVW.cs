namespace ApiIosep.Models.Persona.Geo
{
    public class LocalidadVW
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public int IdProvincia { get; set; }
    }
}
