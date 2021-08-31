using System;

namespace Veterinaria
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaDeNac;
        private string especie;

        public Mascota(string nombre, DateTime fechaDeNac, string especie)
        {
            this.nombre = nombre;
            this.fechaDeNac = fechaDeNac;
            this.especie = especie;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getEspecie()
        {
            return especie;
        }
    }
}
