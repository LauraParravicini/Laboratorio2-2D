using System;
using System.Text;

namespace Biblioteca
{
    public class Empresa
    {
        private Conductor[] conductores;
        private int cantidadConductores;

        public Empresa()
        {
            this.cantidadConductores = 0;
            conductores = new Conductor[20];
        }

        public void CargarConductor(Conductor nuevo)
        {
            this.conductores[this.cantidadConductores] = nuevo;
            this.cantidadConductores++;

        }

        public string MostrarEmpleados()
        {
            StringBuilder mostrar = new StringBuilder();
            for(int i = 0; i < this.cantidadConductores; i++)
            {
                mostrar.AppendLine($"Nombre: {conductores[i].GetNombre()} \n {conductores[i].GetKmsPorDia()}\n");
            }
            return mostrar.ToString();
        }
    }

    public class Conductor
    {
        private string nombre;
        private int[] KmsPorDia;

        public Conductor(string nombre, int[] kmsPorDia)
        {
            this.nombre = nombre;
            KmsPorDia = kmsPorDia;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int[] GetKmsPorDia()
        {
            return KmsPorDia;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetKmsPorDia(int[] KmsPorDia)
        {
            this.KmsPorDia = KmsPorDia;
        }

        

    }
}
