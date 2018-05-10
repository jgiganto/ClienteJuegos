using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ClienteJuegos.Models
{
    public class Juegos
    {
        [JsonProperty("IDJUEGO")]
        public int IdJuego { get; set; }
        [JsonProperty("TITULO")]
        public string Titulo { get; set; }
        [JsonProperty("FOTO")]
        public string Foto { get; set; }
        [JsonProperty("ARGUMENTO")]
        public string Argumento { get; set; }
        [JsonProperty("PRECIO")]
        public int Precio { get; set; }
    }
}