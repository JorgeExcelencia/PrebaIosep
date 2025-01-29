using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Persona
    {
        public Persona()
        {
            Personas_TipoDetalles = new HashSet<Personas_TipoDetalle>();
        }

        public int PersonaID { get; set; }
        /// <summary>
        /// Referencia al usuario de la tabla iosepweb.dbo.aspnetuser
        /// </summary>
        public string? UserName { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public byte? IdTipoDocumento { get; set; }
        public string? Documento { get; set; }
        public string? CBU { get; set; }
        public byte? IdTipoCuil { get; set; }
        public string? Cuil { get; set; }
        public string? Razon_Social { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Url { get; set; }
        public DateTime? Fecha_Nacimiento { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public string? Numero_Cuenta { get; set; }
        public short? SituacionTribID { get; set; }
        public string? Clave_Tributaria { get; set; }
        public int IdLocalidad { get; set; }
        public int? GrupoID { get; set; }
        public int? SubGrupoID { get; set; }
        public string? Domicilio { get; set; }
        public string? Domicilio_Laboral { get; set; }
        /// <summary>
        /// Código de clasificación...Indica cual es el id del clasificador de gastos.
        /// </summary>
        public int? IdClasificaGasto { get; set; }
        public string? Conograma { get; set; }
        public bool Anulado { get; set; }

        public virtual SituacionTributarium? SituacionTrib { get; set; }
        public virtual ICollection<Personas_TipoDetalle> Personas_TipoDetalles { get; set; }
    }
}
