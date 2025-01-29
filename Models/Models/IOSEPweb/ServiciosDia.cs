using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ServiciosDia
    {
        public int ServiociosDiasId { get; set; }
        public int ServicioId { get; set; }
        public int DiaId { get; set; }
        public byte CantidadConsultorios { get; set; }
        public string? MDesde { get; set; }
        public string? MHasta { get; set; }
        public string? TDesde { get; set; }
        public string? THasta { get; set; }
        public string? NDesde { get; set; }
        public string? NHasta { get; set; }
        public string? Frecuencia { get; set; }
        public string? Frecuencia2 { get; set; }
        public string? Frecuencia3 { get; set; }
        public short? Turnos { get; set; }
        public bool? Demanda { get; set; }
        public bool Anulado { get; set; }

        public virtual Dia Dia { get; set; } = null!;
        public virtual Servicio Servicio { get; set; } = null!;
    }
}
