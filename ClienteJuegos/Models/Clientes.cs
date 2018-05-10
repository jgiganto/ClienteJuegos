using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteJuegos.Models
{
    public class Clientes
    {
            [JsonProperty("IDCLIENTE")]
        public int IdCliente { get; set; }
        [JsonProperty("NOMBRE")]
        public string Nombre { get; set; }
        [JsonProperty("APELLIDO")]
        public string Apellido { get; set; }
        [JsonProperty("LOGIN")]
        public string Login { get; set; }
        [JsonProperty("PASS")]
        public string Pass { get; set; }
        
    }
}