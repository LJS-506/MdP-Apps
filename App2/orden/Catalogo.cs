using App2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.orden
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

        public Comparable minimo()
        {
            Comparable p = pila.minimo();
            Comparable c = cola.minimo();
            if (p.sosMenor(c))
            { return pila.minimo();}
            return cola.minimo();
        }

        public Comparable maximo()
        {
            Comparable p = pila.maximo();
            Comparable c = cola.maximo();
            if (p.sosMayor(c))
            { return pila.maximo(); }
            return cola.maximo();
        }

        public void agregar(Comparable c) { }

        public bool contiene(Comparable c)
        {
            if (pila.contiene(c))
            { return true;}
            if (cola.contiene(c))
            { return true;}
            return false;
        }
    }
}
