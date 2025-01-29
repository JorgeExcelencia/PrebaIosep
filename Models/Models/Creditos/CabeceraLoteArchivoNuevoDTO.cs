namespace Models.Models.Creditos
{
    public class CabeceraLoteArchivoNuevoDTO
    {
        public string Planta { get; set; }    // Longitud 1
        public string Control { get; set; }   // Longitud 8
        public string Codigo { get; set; }    // Longitud 3
        public decimal Importe { get; set; }  // Longitud 8 (6 enteros y 2 decimales)
        public int Cuotas { get; set; }       // Longitud 2
        public string Novedad { get; set; }   // Longitud 2
        public int Mes { get; set; }          // Longitud 1
        public int Anio { get; set; }         // Longitud 2
    }
}
