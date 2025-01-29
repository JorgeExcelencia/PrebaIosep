namespace Models.Models.Creditos
{
    public class CreditosNoEfectuados
    {
        public int IdNoefect { get; set; }
        public string NroControl { get; set; } = string.Empty;
        public string Planta { get; set; } = string.Empty;
        public string LugarPago { get; set; } = string.Empty;
        public int A_Numero { get; set; }  
        public string Nombre { get; set; } = string.Empty;
        public string Periodo { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public decimal Importe { get; set; } 
        public string NroCuota { get; set; } = string.Empty;
        public string TotalCuota { get; set; } = string.Empty;
        public string Cuil { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public int IdMotivo { get; set; }
        public bool Anulado {  get; set; } = false;
    }

}
