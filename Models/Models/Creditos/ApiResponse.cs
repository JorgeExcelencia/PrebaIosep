using Newtonsoft.Json;

namespace Models.Models.Creditos
{
    public class ApiResponse
    {
    }
    public class ObtenerTokenResponse
    {
        [JsonProperty(PropertyName = "auth")]
        public bool Auth { get; set; }
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
    public class Datum
    {
        [JsonProperty("cuil")]
        public string cuil { get; set; }

        [JsonProperty("nroControl")]
        public string nroControl { get; set; }

        [JsonProperty("lugarDePago")]
        public string lugarDePago { get; set; }

        [JsonProperty("fechaDeIngreso")]
        public string fechaDeIngreso { get; set; }

        [JsonProperty("antiguedad")]
        public string antiguedad { get; set; }

        [JsonProperty("haberesConAportes")]
        public string haberesConAportes { get; set; }

        [JsonProperty("haberesSinAportes")]
        public string haberesSinAportes { get; set; }

        [JsonProperty("totalDescuentos")]
        public string totalDescuentos { get; set; }

        [JsonProperty("liquido")]
        public string liquido { get; set; }

        [JsonProperty("maximoDescuento")]
        public decimal maximoDescuento { get; set; }
    }

    public class Meta
    {
        [JsonProperty("status")]
        public int status { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("method")]
        public string method { get; set; }

        [JsonProperty("cantidad")]
        public int cantidad { get; set; }
    }

    public class Root
    {
        [JsonProperty("meta")]
        public Meta meta { get; set; }

        [JsonProperty("data")]
        public List<Datum> data { get; set; }
    }
}
