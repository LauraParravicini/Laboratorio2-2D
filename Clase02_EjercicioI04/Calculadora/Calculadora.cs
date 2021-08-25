using System;

namespace Calculadora
{
    public class Calculadora
    {
        public static decimal Calcular(decimal primerOperando, decimal segundoOperando, char operacion)
        {
            decimal resultado = 0;
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
                    break;
            }
            return resultado;
        }

        private static bool Validar(decimal segundoOperando)
        {
            return segundoOperando == 0;
        }
    }
}
