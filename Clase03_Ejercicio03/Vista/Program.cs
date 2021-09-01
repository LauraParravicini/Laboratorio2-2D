using System;
using Biblioteca;
namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Laura","Parravicini","111066");
            estudiante.SetNotaPrimerParcial(10);
            estudiante.SetNotaSegundoParcial(8);

            Console.WriteLine(estudiante.Mostrar());

            Estudiante estudiante2 = new Estudiante("Nacho", "Parravicini", "111066");
            estudiante2.SetNotaPrimerParcial(3);
            estudiante2.SetNotaSegundoParcial(3);

            Console.WriteLine(estudiante2.Mostrar());
        }
    }
}
