using System;
using Calculos;

namespace Clase02_EjercicioI04
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerOperando;
            int segundoOperando;
            char operador;
            double resultado;
            string ingreso;
            do
            {
                Console.WriteLine("Ingrese primer operando: ");
                primerOperando = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo operando: ");
                segundoOperando = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese operador: ");
                operador = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(primerOperando, segundoOperando, operador);
                if (resultado is double.NaN)
                {
                    Console.WriteLine("Error, division por cero.");
                }
                else
                {
                    Console.WriteLine("Resultado: {0}", resultado);
                }
                Console.WriteLine("Salir=: ");
                ingreso = Console.ReadLine();
            } while (ingreso != "salir");
        }
    }
}
