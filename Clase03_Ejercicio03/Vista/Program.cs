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
        }
    }
}
