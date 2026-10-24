using System;
using System.Collections.Generic;
using System.Text;
using App2.Decorator;
using App2.interfaces;
using App2.Observer;
using App2.Strategy;
using App2.Decorator;

namespace App2.Modelo
{
    public class Suscriptor: Perfil, Comparable, IObservadorDeCanales, Mostrable
    {
        // ATT
        private int mesesDeSuscripcion;
        private int horasVistas;
        private IEstrategiaComparacion estrategia = new CompararMeses();

        // Constructor
        public Suscriptor(string n, int i, int c, int h): base(n, i)
        {
            this.mesesDeSuscripcion = c;
            this.horasVistas = h;
        }

        // Meth
        public int getMesesDeSuscripcion()
        { return mesesDeSuscripcion;}

        public int getHorasVistas()
        { return horasVistas;}

        public override string ToString()
        {
            return $"Nombre: {this.getNombre()}\nID: {this.getId()}\nMeses de Suscripción: {mesesDeSuscripcion}\nHoras Vistas: {horasVistas}";
        }

        public void setEstrategia(IEstrategiaComparacion estrategia)
        {
            this.estrategia = estrategia;
        }

        public void verContenido()
        {
            Console.WriteLine("Viendo el nuevo contenido");
        }

        public void reaccionarANotificacion()
        {
            Random rnd = new Random();
            switch(rnd.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("Abriendo la notificación");
                    break;
                case 2:
                    Console.WriteLine("Lo veo después");
                    break;
                case 3:
                    Console.WriteLine("Silenciando notificaciones");
                    break;
            }
        }
        // reimplementacion comparable
        public override bool sosIgual(Comparable otro)
        {
            Suscriptor obj = (Suscriptor)otro;
            return estrategia.sosIgual(this, obj);
        }

        public override bool sosMenor(Comparable otro)
        {
            Suscriptor obj = (Suscriptor)otro;
            return estrategia.sosMenor(this, obj);
        }

        public override bool sosMayor(Comparable otro)
        {
            Suscriptor obj = (Suscriptor)otro;
            return estrategia.sosMayor(this, obj);
        }

        // Observer

        public void actualizarNoti(Canal c)
        {
            reaccionarANotificacion();
        }

        public void actualizarContent(Canal c)
        {
            verContenido();
        }

        // Decorator
        public string mostrarInfo()
        {
            return $"{base.getNombre()} : {getHorasVistas()} horas vistas.";
        }

        public Suscriptor GetSuscriptor()
        {
            return this;
        }
    }
}
