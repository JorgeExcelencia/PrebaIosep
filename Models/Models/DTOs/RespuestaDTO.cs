namespace Models.Models.DTOs
{
    public class RespuestaDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
