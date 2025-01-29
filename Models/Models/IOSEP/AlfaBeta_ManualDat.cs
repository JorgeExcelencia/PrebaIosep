using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_ManualDat
    {
        public string Troquel { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public decimal Ioma1 { get; set; }
        /// <summary>
        /// Marca de uso Normatizado. (‘N’ = No / ‘S’ = Si / ‘A’ = Anexo II / ‘E’ = Plan
        /// SER / ‘T’ = Diag. Tuber., Lepra o Miastenia gravis / ‘C’ = IOMA ACC. )
        /// </summary>
        public string Ioma2 { get; set; } = null!;
        /// <summary>
        /// Marca de cobertura en Internación. (N/S)
        /// </summary>
        public string Ioma3 { get; set; } = null!;
        /// <summary>
        /// Descripción del laboratorio.
        /// </summary>
        public string Laboratorio { get; set; } = null!;
        /// <summary>
        /// Precio sugerido al público en pesos. (Multiplicado por 100, sin decimales)
        /// </summary>
        public decimal Precio { get; set; }
        /// <summary>
        /// Fecha de vigencia del precio.(AAAAMMDD)
        /// </summary>
        public string Fecha { get; set; } = null!;
        /// <summary>
        /// 0 = No controlado
        /// 2 = Psicotrópico II
        /// 3 = Psicotrópico III
        /// 4 = Psicotrópico IV
        /// 6 = Estupefaciente I
        /// 7 = Estupefaciente II
        /// 8 = Estupefaciente III
        /// 9 = Succinilcolina
        /// A = Venta Vigilada
        /// </summary>
        public string Marca { get; set; } = null!;
        /// <summary>
        /// 1 = Importado; 0 = Nacional
        /// </summary>
        public string Importado { get; set; } = null!;
        /// <summary>
        /// 1 = Vta. Libre
        /// 2 = Vta. Bajo Receta
        /// 3 = Vta. Bajo Receta Archivada
        /// 4 = Vta. Bajo Receta Oficial
        /// 5 = Pendiente
        /// 6 = Bajo control médico recomendado
        /// 7 = No clasificado
        /// </summary>
        public string TipoVenta { get; set; } = null!;
        /// <summary>
        /// 1 = con IVA a farmacia.
        /// </summary>
        public string Iva { get; set; } = null!;
        /// <summary>
        /// 0 = Sin Información (Sin descuento)
        /// 1 = 70%
        /// 2 = 50 %.
        /// 3 = 45%
        /// 4 = 100% EMPADRONAMIENTO PREVIO
        /// 5 = 30%.
        /// 6 = 80 %.
        /// 7 = 40%
        /// 8 = 60%
        /// 9 = 65%
        /// A =USO AUTORIZADO
        /// B = 55%
        /// C = 75%
        /// D = 35%
        /// E = 100% CON AUTORIZACIÓN PREVIA
        /// </summary>
        public string Pami { get; set; } = null!;
        public int CodLab { get; set; }
        public int NroRegistro { get; set; }
        /// <summary>
        /// 0 = Presentación activa.
        /// 1 = Presentación dada de baja.
        /// </summary>
        public string Baja { get; set; } = null!;
        public string CodBarras { get; set; } = null!;
        /// <summary>
        /// 1 = El producto no es divisible.
        /// </summary>
        public decimal Unidades { get; set; }
        /// <summary>
        /// 1 = Menor,
        /// 2 = Siguiente,
        /// 3 = Grande (de dos presentaciones),
        /// 4 = Gigante,
        /// 5 = Grande (de mas de dos presentaciones),
        /// 6 = Antibiótico Monodosis,
        /// 7 = Antibiótico Multidosis,
        /// 8 = Soluciones Parenterales,
        /// 9 = Hospitalario, A = No clasificado
        /// </summary>
        public string Tamano { get; set; } = null!;
        /// <summary>
        /// 1 = Debe conservarse en heladera.
        /// </summary>
        public string Heladera { get; set; } = null!;
        /// <summary>
        /// Marca de cobertura de SIFAR. (N/S)
        /// </summary>
        public string Sifar { get; set; } = null!;
        /// <summary>
        /// Espacios en blanco.
        /// </summary>
        public string Blanco { get; set; } = null!;
        public string Gravamen { get; set; } = null!;
        public string Blanco2 { get; set; } = null!;

        public virtual Tipo_VentaAlfaBetum TipoVentaNavigation { get; set; } = null!;
    }
}
