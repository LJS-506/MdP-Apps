using System;
using System.Collections.Generic;
using System.Text;
using App2.interfaces;
using App2.Modelo;

namespace App2.Strategy
{
    public interface IEstrategiaComparacion
    {
        public bool sosIgual(Suscriptor a, Suscriptor b);
        public bool sosMayor(Suscriptor a, Suscriptor b);
        public bool sosMenor(Suscriptor a, Suscriptor b);
    }
}
