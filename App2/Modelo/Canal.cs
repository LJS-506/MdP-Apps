using App2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using App2.Observer;

namespace App2.Modelo
{
    public class Canal:Comparable, IObservado
    {
        private string nombre;

        public Canal(string nombre)
        {
            this.nombre = nombre;
        }

        public void publicarContenido()
        {
            Console.WriteLine($"{nombre} publicó contenido nuevo");
            this.notificarContenido();
        }

        public void iniciarEnVivo()
        {
            Console.WriteLine($"{nombre} está en vivo");
            this.notificarVivo();
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

        // Observer
        private List<IObservador> observadores = new List<IObservador>();
        public void agregarObservador(IObservador obs)
        {
            observadores.Add(obs);
        }

        public void notificarContenido()
        {
            foreach (IObservador obs in observadores)
            {
                if (obs is IObservadorDeCanales observadorDeCanales)
                {
                    observadorDeCanales.actualizarContent(this);
                }
            }
        }

        public void notificarVivo()
        {
            foreach (IObservador obs in observadores)
            {
                if (obs is IObservadorDeCanales observadorDeCanales)
                {
                    observadorDeCanales.actualizarNoti(this);
                }
            }
        }
    }
}
