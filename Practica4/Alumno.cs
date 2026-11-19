using System;

namespace Practica4
{
    public class Alumno
    {
        private string nombre;
        private int legajo;

        public Alumno(int legajo, string nombre)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public string getNombre()
        {
            return nombre;
        }

    }
}