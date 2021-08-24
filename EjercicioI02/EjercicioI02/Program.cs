using System;

namespace EjercicioI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                int cuadrado = (int)Math.Pow(numero, 2);
                int cubo = (int)Math.Pow(numero, 3);
                Console.WriteLine("Cuadrado del numero: {0}\nCubo del numero: {1}",cuadrado,cubo);
            }
            else
            {
                Console.WriteLine("ERROR, numero invalido\n");
            }
 
        }
    }
}
