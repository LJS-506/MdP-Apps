using System;
using System.Collections.Generic;
using System.Text;
using App2.Modelo;

namespace App2.Strategy
{
    public class CompararID : IEstrategiaComparacion
    {
        public bool sosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getId() == b.getId();
        }

        public bool sosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getId() > b.getId();
        }

        public bool sosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getId() < b.getId();
        }
    }
}
