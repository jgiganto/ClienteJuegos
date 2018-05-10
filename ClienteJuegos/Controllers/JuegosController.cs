using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks; 
using ClienteJuegos.Models;

namespace ClienteJuegos.Controllers
{
    public class JuegosController : Controller
    {
        ModeloJuegos modelo;
        public JuegosController()
        {
            this.modelo = new ModeloJuegos();
        }
         
        public async Task<ActionResult> ListaJuegos()
        {
            List<Juegos> juegos = await modelo.GetJuegos();
            return View(juegos);
        } 

         
        public async Task<ActionResult> Juego(int? IdJuego)
        {
            Juegos juego = await modelo.GetJuego(IdJuego.GetValueOrDefault());
            return View(juego);
        }
         
        public ActionResult Comprar( )
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Comprar(int? idcliente, int? idjuego)
        {
            await modelo.Comprar(idcliente.GetValueOrDefault(), idjuego.GetValueOrDefault());
            return View();  
        }

        public async Task<ActionResult> ListaPedidos(int? idcliente)
        {
            await modelo.PedidosCliente(idcliente.GetValueOrDefault());
            return View();
        }

    }
}