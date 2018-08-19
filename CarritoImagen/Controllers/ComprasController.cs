using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarritoImagen.Models;
namespace CarritoImagen.Controllers
{
    public class ComprasController : Controller
    {
        CarritoImagenEntidades de = new CarritoImagenEntidades();
        // GET: Comprando
        public ActionResult Index()
        {
            return View();
        }
        private int existe(int id)
        {
            List<Articulo> cart = (List<Articulo>)Session["cart"];
            for (int x = 0; x < cart.Count; x++)
                if (cart[x].Pr.ID_Producto == id)
                    return x;
            return -1;
        }

        public ActionResult eliminar(int id)
        {

            int index = existe(id);
            List<Articulo> cart = (List<Articulo>)Session["Cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");

        }

        public ActionResult ordenar_ahora(int id)
        {
            if (Session["cart"] == null)
            {
                List<Articulo> cart = new List<Articulo>();
                cart.Add(new Articulo(de.Productos.Find(id), 1));
                Session["cart"] = cart;


            }
            else
            {
                List<Articulo> cart = (List<Articulo>)Session["Cart"];
                int index = existe(id);
                if (index == -1)
                    cart.Add(new Articulo(de.Productos.Find(id), 1));
                else
                    cart[index].Cantidad++;

                Session["cart"] = cart;

            }
            return View("Cart");
        }


    }
}