using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona nacho = new Persona("Nacho", new DateTime(2000, 11, 07, 1, 1, 1), "41331217");
            Persona laura = new Persona("Lau", new DateTime(2007, 7, 3, 1, 1, 1), "41231447");
            Console.WriteLine($"{nacho.GetNombre()} es {nacho.EsMayorDeEdad()}");
            Console.WriteLine($"{laura.GetNombre()} es {laura.EsMayorDeEdad()}");
        }
    }
}
