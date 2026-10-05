using App1.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.orden
{
    internal class Catalogo: IColeccionable
    {
        // ATT
        private Pila pila;
        private Cola cola;

        // Constructor
        public Catalogo(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        // implementacion coleccionable
        public int cuantos()
        {
            int cantidad = pila.cuantos() + cola.cuantos();
            return cantidad;
        }

        public interfaces.Comparable minimo()
        {
            int p = int.Parse(pila.minimo().ToString());
            int c = int.Parse(cola.minimo().ToString());
            if (p<c)
            { return pila.minimo();}
            return cola.minimo();
        }

        public interfaces.Comparable maximo()
        {
            int p = int.Parse(pila.maximo().ToString());
            int c = int.Parse(cola.maximo().ToString());
            if (p>c)
            { return pila.maximo(); }
            return cola.maximo();
        }

        public void agregar(interfaces.Comparable c) { }

        public bool contiene(interfaces.Comparable c)
        {
            if (pila.contiene(c))
            { return true;}
            if (cola.contiene(c))
            { return true;}
            return false;
        }
    }
}
