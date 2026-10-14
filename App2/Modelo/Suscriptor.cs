using System;
using System.Collections.Generic;
using System.Text;
using App2.interfaces;
using App2.Strategy;

namespace App2.Modelo
{
    public class Suscriptor: Perfil, Comparable
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
    }
}
