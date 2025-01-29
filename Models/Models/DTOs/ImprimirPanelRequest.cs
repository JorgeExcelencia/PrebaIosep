using ApiIosep.Models.StoreProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.DTOs
{
    public class ImprimirPanelRequest
    {
        public List<IosepSALUDAfiliadosEmp>? Data { get; set; }
        public string? Periodo { get; set; }
        public string? UsuarioImprime { get; set; }
    }
}
