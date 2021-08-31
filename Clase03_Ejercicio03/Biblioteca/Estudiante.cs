using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //Solo se puede usar atributos estaticos en constructores estaticos y estos no necesitan definir el modificador de acceso
        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        {
            double promedio = (notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;
        }

        public int CalcularFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre: {nombre} - Apellido: {apellido} - Legajo: {legajo}");
            datos.AppendLine($"Nota Primer parcial: {notaPrimerParcial} - Nota Segundo Parcial: {notaSegundoParcial}");
            datos.AppendLine($"Promedio: {CalcularPromedio()}");
            int notaFinal = CalcularFinal();
            if (notaFinal != -1)
            {
                datos.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                datos.AppendLine($"Alumno desaprobado");
            }
            
            return datos.ToString();
        }
    }
}
