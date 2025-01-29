using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ExpedienteGlosado
    {
        public int ExpedienteGlosadoId { get; set; }
        public int ExpedienteId { get; set; }
        public string NroExpediente { get; set; } = null!;
        public string RefExpediente { get; set; } = null!;
        public string FechaExpediente { get; set; } = null!;
        public int ReintegrosEncabezadoID { get; set; }
        public string ExpteMadre { get; set; } = null!;
    }
}
