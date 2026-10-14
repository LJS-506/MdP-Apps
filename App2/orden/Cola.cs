using App2.interfaces;
using App2.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.orden
{
    internal class Cola: IColeccionable, Iterable
    {
        // ATT
        private List<Comparable> listaElems;

        // Constructor
        public Cola()
        {
            listaElems = new List<Comparable>();
        }


        // Meth
        public void agregar(Comparable c)
        {
            listaElems.Add(c);
        }

        public Comparable? desencolar()
        {
            if (listaElems.Count == 0) {return null;}
            Comparable elem = listaElems[0];
            listaElems.RemoveAt(0);
            return elem;
        }

        public Comparable? peek()
        {
            return listaElems[0];
        }

        // implementacion coleccionable
        public int cuantos()
        {
            return listaElems.Count;
        }

        public Comparable minimo()
        {
            Comparable minimo = listaElems[0];
            for (int i=1; i<listaElems.Count; i++)
            {
                if (listaElems[i].sosMenor(minimo)) {minimo = listaElems[i];}
            }
            return minimo;
        }
        
        public Comparable maximo()
        {
            Comparable maximo = listaElems[0];
            for (int i=1; i<listaElems.Count; i++)
            {
                if (listaElems[i].sosMayor(maximo)) {maximo = listaElems[i];}
            }
            return maximo;
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable elem in listaElems)
            {
                if (elem.sosIgual(c)) {return true;}
            }
            return false;
        }

        // Implementacion Iterable
        public Iterador crearIterador()
        {
            return new IteradordeComparables(listaElems);
        }
    }
}
