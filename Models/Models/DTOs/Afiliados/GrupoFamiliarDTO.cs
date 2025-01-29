namespace ApiIosep.Models.DTOs.Afiliados
{
    public class GrupoFamiliarDTO
    {
        public int AfiliadoID { get; set; }
        public string Familiar { get; set; }
        public string Cuil { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GetFechaNacimiento
        {
            get
            {
                return FechaNacimiento.ToString("dd/MM/yyyy");
            }
        }
        public int Edad { get { 
                return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
            }
        }
    }
}
