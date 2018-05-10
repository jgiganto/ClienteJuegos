using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace ClienteJuegos.Models
{
    public class Pedidos
    {
        [JsonProperty("IDCLIENTE")]
        public int IdCliente { get; set; }
        [JsonProperty("IDJUEGO")]
        public int IdJuego { get; set; }
        [JsonProperty("FECHA")]
        public DateTime Fecha { get; set; }
        [JsonProperty("PRECIO")]
        public int Precio { get; set; }
        [JsonProperty("CANTIDAD")]
        public int Cantidad { get; set; }
    }
}