using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwVerQuirofano
    {
        public int idinternado { get; set; }
        public string nombre { get; set; } = null!;
        public string Titular { get; set; } = null!;
        public short idestado { get; set; }
        public string cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public int? IdQuirofano { get; set; }
        public bool quirofano { get; set; }
        public int? IdCirujano { get; set; }
        public string? Cirujano { get; set; }
        public string? nCirujano { get; set; }
        public int? IdAnestesista { get; set; }
        public string? Anestesista { get; set; }
        public string? nAnestesista { get; set; }
        public int? IdBiopsia { get; set; }
        public string? Biopsia { get; set; }
        public string? nBiopsia { get; set; }
        public int? IdAyudante1 { get; set; }
        public string? Ayudante1 { get; set; }
        public string? nAyudante1 { get; set; }
        public int? IdAyudante2 { get; set; }
        public string? Ayudante2 { get; set; }
        public string? nAyudante2 { get; set; }
        public int? IdInstrumentador { get; set; }
        public string? Instrumentador { get; set; }
        public string? nInstrumentador { get; set; }
        public int? IdNeonatologo { get; set; }
        public string? Neonatologo { get; set; }
        public string? nNeonatologo { get; set; }
        public int? IdCirQuirofano { get; set; }
        public string? CirQuirofano { get; set; }
        public string? nCirQuirofano { get; set; }
        public int? IdLaboratorio { get; set; }
        public string? Laboratorio { get; set; }
        public string? nLaboratorio { get; set; }
        public int? IdLaparoscopico { get; set; }
        public string? Laparoscopico { get; set; }
        public string? nLaparoscopico { get; set; }
        public int? IdMonitoraje { get; set; }
        public string? Monitoraje { get; set; }
        public string? nMonitoraje { get; set; }
        public int? IdRadiologo { get; set; }
        public string? Radiologo { get; set; }
        public string? nRadiologo { get; set; }
        public bool? Anulada { get; set; }
        public int? IdHemoterapia { get; set; }
        public string? Hemoterapia { get; set; }
        public string? nHemoterapia { get; set; }
        public string? Observaciones { get; set; }
        public string? Varios { get; set; }
    }
}
