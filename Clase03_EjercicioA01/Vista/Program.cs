using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa ViaCargo = new Empresa();
            int[] kmsPepe = { 100, 500, 1, 1, 250, 1, 1 };
            Conductor pepe = new Conductor("Pepe",kmsPepe);

            int[] kmsLau = { 300, 0, 1000, 1000, 1, 1, 1 };
            Conductor lau = new Conductor("Lau", kmsLau);

            ViaCargo.CargarConductor(pepe);
            ViaCargo.CargarConductor(lau);

            Console.WriteLine(ViaCargo.MostrarEmpleados());

            Console.WriteLine("Hello World!");
        }
    }
}
