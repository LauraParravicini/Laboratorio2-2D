using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        private static float tempCelsius;
        private static float tempKelvin;
        
        static void Main(string[] args)
        {
            tempCelsius = 30;
            tempKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(tempCelsius);
            MostrarTemperatura(tempKelvin, tempCelsius);
        }

        public static void MostrarTemperatura(float tempKelvin, float tempCelsius)
        {
            Console.WriteLine("{0} °K", tempKelvin);
            Console.WriteLine("{0} °C", tempCelsius);
        }
    }
}
