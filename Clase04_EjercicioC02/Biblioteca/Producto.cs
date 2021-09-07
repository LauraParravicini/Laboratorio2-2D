using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string mostrar = p.codigoDeBarra + " " + p.marca + " " + p.precio;
            return mostrar;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool isEqual = false;
            if(p1 is not null && p2 is not null && p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
            {
               isEqual = true;
            }
            return isEqual;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            bool isInequal = false;
            if (p1 is not null && p2 is not null && p1.codigoDeBarra != p2.codigoDeBarra || p1.marca != p2.marca)
            {
                isInequal = true;
            }
            return isInequal;
        }

        public static bool operator ==(Producto p1, string p2)
        {
            bool isEqual = false;
            if (p1 is not null && p2 is not null && p1.marca == p2)
            {
                isEqual = true;
            }
            return isEqual;
        }
        public static bool operator !=(Producto p1, string p2)
        {
            bool isInequal = false;
            if (p1 is not null && p2 is not null && p1.marca != p2)
            {
                isInequal = true;
            }
            return isInequal;
        }
    }

    public class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            Producto[] productos = e.GetProductos();
            StringBuilder listado = new StringBuilder();
            for (int i = 0; i < productos.Length; i++)
            {
                 listado.AppendLine( Producto.MostrarProducto(productos[i]) );
            }
            return listado.ToString();
        }

        //Devuelve si Producto existe en el Estante
        public static bool operator ==(Estante e, Producto p)
        {
            bool isEqual = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if(e.productos[i] is not null && e.productos[i] == p)
                {
                    isEqual = true;
                    break;
                }
            }
            return isEqual;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            /*
            bool isInequal = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    isInequal = true;
                    break;
                }
            }
            return isInequal;
            */
            //Si la igualdad devuelve false es xq eran distintos, por ende != es true
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e == p)
            {
                return false;
            }

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null)
                {
                    e.productos[i] = p;
                    return true;
                }

                /*
                if(e.productos[i] is null) 
                {
                    
                }
                 */
            }
            //El array esta lleno.
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            //Nach code
            if(e == p)
            {
                int productoIndex = Array.IndexOf(e.productos, p);
                e.productos[productoIndex] = null;
            }
            return e;
        }

    }
}
