using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;

namespace ClienteJuegos.Models
{
    public class ModeloJuegos
    {
        private String UrlApi;
        private MediaTypeWithQualityHeaderValue media;

        public ModeloJuegos()
        {
            this.UrlApi = "http://localhost:64357/";
                //"ttp://apijuegosjgd.azurewebsites.net/";
            this.media =
                new MediaTypeWithQualityHeaderValue("application/json");

        }

        public async Task<List<Juegos>> GetJuegos()
        {
            using (HttpClient cliente = new HttpClient())
            {
                String peticion = "api/ListaJuegos";
                cliente.BaseAddress = new Uri(this.UrlApi);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(media);
                HttpResponseMessage respuesta =
                    await cliente.GetAsync(peticion);
                if (respuesta.IsSuccessStatusCode)
                {
                    List<Juegos> juegos =
                        await respuesta.Content.ReadAsAsync<List<Juegos>>();
                    return juegos;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<Juegos> GetJuego(int idjuego)
        {
            using (HttpClient cliente = new HttpClient())
            {
                String peticion = "api/juego/" + idjuego.ToString();
                cliente.BaseAddress = new Uri(this.UrlApi);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(media);
                HttpResponseMessage respuesta =
                    await cliente.GetAsync(peticion);
                if (respuesta.IsSuccessStatusCode)
                {
                    Juegos juegos =
                        await respuesta.Content.ReadAsAsync<Juegos>();
                    return juegos;
                }
                else
                {
                    return null;
                }
            }
        }
       
        public async Task Comprar(int idcliente, int idjuego)
        {
            using (HttpClient cliente = new HttpClient())
            {
                String peticion = "api/comprar/" + idcliente + "/" + idjuego;
                cliente.BaseAddress = new Uri(this.UrlApi);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(media);
                StringContent content =
                    new StringContent(""
                    , System.Text.Encoding.UTF8, "application/json");
                await cliente.PostAsync(peticion, content);
            }
        }

       // api/ListaPedidos/{idcliente


        public async Task<Pedidos> PedidosCliente(int idcliente)
        {
            using (HttpClient cliente = new HttpClient())
            {
                String peticion = "api/ListaPedidos/" + idcliente;
                cliente.BaseAddress = new Uri(this.UrlApi);
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(media);
                HttpResponseMessage respuesta =
                    await cliente.GetAsync(peticion);
                if (respuesta.IsSuccessStatusCode)
                {
                    Pedidos pedidos  =
                        await respuesta.Content.ReadAsAsync<Pedidos>();
                    return pedidos;
                }
                else
                {
                    return null;
                }
            }
        }


    }

}
 
