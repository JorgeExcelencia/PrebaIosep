namespace Models.Models.DTOs
{
    public class RespuestaIOSEP
    {
        /// <summary>
        /// Indica si la consulta presenta error.
        /// </summary>
        public bool Error { get; set; }
        /// <summary>
        /// Descripción del error.
        /// </summary>
        public string DescripcionError { get; set; }
    }
}
