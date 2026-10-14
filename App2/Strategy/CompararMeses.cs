using System;
using System.Collections.Generic;
using System.Text;
using App2.Modelo;

namespace App2.Strategy
{
    internal class CompararMeses : IEstrategiaComparacion
    {
        public bool sosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getMesesDeSuscripcion() == b.getMesesDeSuscripcion();
        }
        public bool sosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getMesesDeSuscripcion() > b.getMesesDeSuscripcion();
        }
        public bool sosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getMesesDeSuscripcion() < b.getMesesDeSuscripcion();
        }
    }
}
