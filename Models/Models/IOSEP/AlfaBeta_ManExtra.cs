using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AlfaBeta_ManExtra
    {
        /// <summary>
        /// Manual.Dat
        /// </summary>
        public int NroRegistro { get; set; }
        /// <summary>
        /// Tamanos.txt
        /// </summary>
        public byte Tamanos { get; set; }
        /// <summary>
        /// Acciofar.txt
        /// </summary>
        public int Acciofar { get; set; }
        /// <summary>
        /// Monodro.txt
        /// </summary>
        public int Monodro { get; set; }
        /// <summary>
        /// Formas.txt
        /// </summary>
        public int Formas { get; set; }
        public string Potencia { get; set; } = null!;
        /// <summary>
        /// uPotenci.txt
        /// </summary>
        public int uPotenci { get; set; }
        /// <summary>
        /// tipoUnid.txt
        /// </summary>
        public int tipoUnid { get; set; }
        /// <summary>
        /// Vias.txt
        /// </summary>
        public int Vias { get; set; }

        public virtual AlfaBeta_AccioFar AcciofarNavigation { get; set; } = null!;
        public virtual AlfaBeta_Forma FormasNavigation { get; set; } = null!;
        public virtual AlfaBeta_MonoDro MonodroNavigation { get; set; } = null!;
        public virtual AlfaBeta_ManualDat NroRegistroNavigation { get; set; } = null!;
        public virtual AlfaBeta_via ViasNavigation { get; set; } = null!;
        public virtual AlfaBeta_tipoUnid tipoUn { get; set; } = null!;
        public virtual AlfaBeta_uPotenci uPotenciNavigation { get; set; } = null!;
    }
}
