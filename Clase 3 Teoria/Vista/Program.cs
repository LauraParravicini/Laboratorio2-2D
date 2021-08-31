using System;
using Veterinaria;
namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota felix = new Mascota("Felix", new DateTime(1998,01,01),"Gato");
            Console.WriteLine($" {felix.getNombre()}- {felix.getEspecie()}");
        }
    }
}
