using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarritoImagen.Models;

namespace CarritoImagen.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            CarritoImagenEntidades de = new CarritoImagenEntidades();
            ViewBag.listProducts = de.Productos.ToList();
            return View();
        }
    }
}