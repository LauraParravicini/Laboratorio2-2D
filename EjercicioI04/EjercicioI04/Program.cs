using System;

namespace EjercicioI04
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfectos = 0;
            int numero = 2;
            int suma = 0;
            while(perfectos < 4)
            {
                suma = 0;
                for(int i = 1; i < numero; i++)
                {
                    if(numero % i == 0)
                    {
                        suma += i;
                    }
                }
                if(suma == numero)
                {
                    Console.WriteLine("Perfecto: {0}",numero);
                    perfectos++;
                }
                numero++;
            }
        }
    }
}
