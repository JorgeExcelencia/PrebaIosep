namespace ApiIosep.Models.CtaCte.MovDet
{
    public class Mov
    {
        public int IdMovimiento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Det> Detalle { get; set; } = new List<Det>();
    }
}
