using System;

namespace Biblioteca
{
    /// <summary>
    /// Clase que contiene funcionalidades de conversion de Temperatura
    /// </summary>
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        /// <summary>
        /// Recibe una temp en Celsius y devuelve en Kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">Temp a convertir</param>
        /// <returns>Temp convertida a Kelvin</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;
            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;
            return temperaturaCelsius;
        }
    }
}
