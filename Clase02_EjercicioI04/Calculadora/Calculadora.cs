using System;

namespace Calculos
{
    public class Calculadora
    {
        public static double Calcular(double primerOperando, double segundoOperando, char operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        resultado = double.NaN;
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(double segundoOperando)
        {
            return segundoOperando != 0;
        }
    }
}
