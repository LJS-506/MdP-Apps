using App2.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Decorator
{
    public interface Mostrable
    {
        public string mostrarInfo();

        public Suscriptor GetSuscriptor();
    }
}
