using System;

namespace EjercicioI01
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int promedio = 0;
            int cantidad = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroS = Console.ReadLine();
                int numero = int.Parse(numeroS);

                if (numero > maximo)
                {
                    maximo = numero;
                }
                if(numero < minimo)
                {
                    minimo = numero;
                }
                promedio += numero;
                cantidad++;
            }
            promedio /= cantidad;
            Console.WriteLine("El numero maximo ingresado: {0}, el minimo {1}, el promedio {2}",maximo,minimo,promedio);
        }
    }
}
