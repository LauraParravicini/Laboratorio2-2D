using System;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Valida que Valor este dentro del rango especificado en minimo y maximo
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Verdadero si valida, falso si no</returns>
        public static bool Validar(int valor, int min, int max)
        {          
            return valor > min && valor < max;
        }
    }
}
