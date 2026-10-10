using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Modelo
{
    internal class Suscriptor: Perfil, interfaces.Comparable
    {
        // ATT
        private int mesesDeSuscripcion;
        private int horasVistas;

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
            return mesesDeSuscripcion.ToString();
        }

        // reimplementacion comparable
        public override bool sosIgual(interfaces.Comparable otro)
        {
            Suscriptor obj = (Suscriptor)otro;
            return obj.getMesesDeSuscripcion() == mesesDeSuscripcion;
        }

        public override bool sosMenor(interfaces.Comparable otro)
        {
            Suscriptor obj = (Suscriptor)otro;
            return mesesDeSuscripcion < obj.getMesesDeSuscripcion();
        }

        public override bool sosMayor(interfaces.Comparable otro)
        {
            Suscriptor obj = (Suscriptor)otro;
            return mesesDeSuscripcion > obj.getMesesDeSuscripcion();
        }
    }
}
