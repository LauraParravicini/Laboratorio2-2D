using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public string GetDNI()
        {
            return dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void SetDNI(string DNI)
        {
            this.dni = DNI;
        }

        private int CalcularEdad()
        {

            int age = DateTime.Now.Year - fechaDeNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaDeNacimiento.DayOfYear)
            {
                age -= 1;
            }

            return age;

        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.Append($"Nombre: {nombre} - DNI: {dni} - Fecha de Nac. : {fechaDeNacimiento} -");
            mostrar.AppendLine($" Edad: {CalcularEdad()}");
            return mostrar.ToString();
        }

        public string EsMayorDeEdad()
        {
            return (CalcularEdad() >= 18 ? "Mayor de edad" : "Menor de edad");
        }
    
    }
}
