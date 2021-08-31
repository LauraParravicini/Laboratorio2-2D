using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private int titular;
        private decimal cantidad;

        public Cuenta(int titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public int GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append($"Titular: {titular} - Cantidad: {cantidad}");
            return datos.ToString();
        }
        
        public void Ingresar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(decimal cantidad)
        {
            this.cantidad -= cantidad;
        }
    }
}
