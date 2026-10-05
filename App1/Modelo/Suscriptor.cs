using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Modelo
{
    internal class Suscriptor: Perfil
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
    }
}
