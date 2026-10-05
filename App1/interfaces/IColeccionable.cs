using System;
using System.Collections.Generic;
using System.Text;

namespace App1.interfaces
{
    public interface IColeccionable
    {
        //Representa objetos que almacenan comparables
        public int cuantos();

        public IComparable minimo();

        public IComparable maximo();

        public void agregar(IComparable c);

        public bool contiene(IComparable c);
    }
}
