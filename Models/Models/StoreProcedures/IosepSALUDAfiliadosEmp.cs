using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Models.StoreProcedures
{
    [Keyless]
    public class IosepSALUDAfiliadosEmp
    {
        public string CodEmpresa { get; set; }
        public string Empresa { get; set; }
        public string Cuil { get; set; }
        public string CuilTitular { get; set; }
        public string A_Numero { get; set; }
        public string Nombre { get; set; }
        public decimal ValorCuota { get; set; }
        public int Edad { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string Sexo { get; set; }
        public int IdFliar { get; set; }
        public string Fliar { get; set; }
        public decimal Deuda { get; set; }
    }
}
