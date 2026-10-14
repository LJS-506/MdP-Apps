using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using App2.Modelo;

namespace App2.Strategy
{
    public class CompararNombre : IEstrategiaComparacion
    {
        public bool sosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getNombre() == b.getNombre();
        }

        public bool sosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getNombre().CompareTo(b.getNombre()) > 0;
        }
         
        public bool sosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getNombre().CompareTo(b.getNombre()) < 0;
        }
    }
}
