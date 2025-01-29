using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrescripcionElectronica
    {
        public int IdPrescripcionElectronica { get; set; }
        public int IdOrdenSinCoseguro { get; set; }
        public DateTime Fecha { get; set; }
        public string? PrescriptorNombre { get; set; }
        public string? PrescriptorMatricula { get; set; }
        public string? PrescriptorCUIT { get; set; }
        public string ObraSocial { get; set; } = null!;
        public string CodigoRNOS { get; set; } = null!;
        public string BeneficiarioNumero { get; set; } = null!;
        public string BeneficiarioNombre { get; set; } = null!;
        public string BeneficiarioTipoDocumento { get; set; } = null!;
        public string BeneficiarioDocumento { get; set; } = null!;
        public string? BeneficiarioCorreo { get; set; }
        public string? BeneficiarioCelular { get; set; }
        public string BeneficiarioCUIL { get; set; } = null!;
        public string? TratamientoProlongado { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}
