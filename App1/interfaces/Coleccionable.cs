using System;
using System.Collections.Generic;
using System.Text;

namespace App1.interfaces
{
    internal interface Coleccionable
    {
        //Representa objetos que almacenan comparables
        public int cuantos();

        public Comparable minimo();

        public Comparable maximo();

        public void agregar(Comparable c);

        public bool contiene(Comparable c);
    }
}
