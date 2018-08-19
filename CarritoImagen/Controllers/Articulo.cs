using CarritoImagen.Models;

namespace CarritoImagen.Controllers
{
    public class Articulo
    {
        private Productos pr = new Productos();
        private int cantidad;


        public Productos Pr
        {
            get { return pr; }
            set { pr = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Articulo(Productos producto, int cantidad)
        {
            this.pr = producto;
            this.cantidad = cantidad;
        }
    }
}