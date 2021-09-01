using System;

namespace ClassLibrary1
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long operador1, long operador2)
        {
            this.cantidadSumas++;
            return operador1 + operador2;
        }

        public string Sumar(string operador1, string operador2)
        {
            this.cantidadSumas++;
            return operador1 + operador2;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumadorA, Sumador sumadorB)
        {
            return (sumadorA.cantidadSumas+sumadorB.cantidadSumas);
        }

        public static bool operator |(Sumador sumadorA, Sumador sumadorB)
        {
            return (sumadorA.cantidadSumas == sumadorB.cantidadSumas);
        }
    }
}
