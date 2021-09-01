using System;
using ClassLibrary1;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador(3);
            Sumador suma2 = new Sumador();

            long resultado = suma + suma2;
            bool prueba = suma | suma2;
            int cantidadEj = (int)suma;

            Console.WriteLine($"{resultado} - {prueba} - {cantidadEj}");
        }
    }
}
