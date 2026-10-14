using System;
using System.Collections.Generic;
using System.Text;
using App2.Modelo;

namespace App2.Strategy
{
    internal class CompararHorasVistas : IEstrategiaComparacion
    {
        public bool sosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() == b.getHorasVistas();
        }
        public bool sosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() > b.getHorasVistas();
        }
        public bool sosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() < b.getHorasVistas();
        }
    }
}
