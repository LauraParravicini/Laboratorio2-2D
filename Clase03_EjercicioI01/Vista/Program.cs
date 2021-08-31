using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta(413999,70000);

            miCuenta.Ingresar(15000);
            Console.WriteLine(miCuenta.Mostrar());

            miCuenta.Retirar(50000);
            Console.WriteLine(miCuenta.Mostrar());
        }
    }
}
