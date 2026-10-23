using App2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Modelo
{
    public class Canal:Comparable
    {
        private string nombre;

        public Canal(string nombre)
        {
            this.nombre = nombre;
        }

        public void publicarContenido()
        {
            Console.WriteLine($"{nombre} publicó contenido nuevo");
        }

        public void iniciarEnVivo()
        {
            Console.WriteLine($"{nombre} está en vivo");
        }

        public string getNombre()
        {
            return nombre;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}";
        }

        public bool sosIgual(Comparable otro)
        {
            Canal obj = (Canal)otro;
            return obj.getNombre() == nombre;
        }

        public bool sosMayor(Comparable otro)
        {
            Canal obj = (Canal)otro;
            return nombre.CompareTo(obj.getNombre()) > 0;
        }

        public bool sosMenor(Comparable otro)
        {
            Canal obj = (Canal)otro;
            return nombre.CompareTo(obj.getNombre()) < 0;
        }
    }
}
