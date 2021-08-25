using System;
using Biblioteca;

namespace Clase02_EjercicioI01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int promedio = 0;
            int i = 0;
            while(i < 10)
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numero) && Validador.Validar(numero, -100, 100))
                {
                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }
                    promedio += numero;
                    i++;
                }
                else
                {
                    Console.WriteLine("Dato erroneo. Reingrese");
                }
            }
            promedio /= 10;
            Console.Write($"Maximo: {maximo} - Minimo {minimo} - Promedio {promedio} ");
        }
    }
}
