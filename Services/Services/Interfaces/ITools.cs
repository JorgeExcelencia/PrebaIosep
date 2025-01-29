namespace ApiIosep.Services.Interfaces
{
    public interface ITools
    {
        string RandomString(int length, bool onlyNumber = false, bool onlyMayus = true);
        string CodigoBarra(string comprobante, decimal importe, DateTime vence, DateTime segVence);
    }
}
