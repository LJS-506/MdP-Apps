using System;
using System.Collections.Generic;
using System.Text;
using App1.interfaces;

namespace App1.orden
{
    internal class Pila: Coleccionable
    {
        // ATT
        private List<Comparable> listaElems;

        // Construct
        public Pila()
        {
            listaElems = new List<Comparable>();
        }

        // Meth
        public void agregar(Comparable c)
        {
            listaElems.Add(c);
        }

        public Comparable desapilar()
        {
            if (listaElems.Count == 0)
            {
                return null;
            }
            Comparable elem = listaElems[listaElems.Count-1];
            listaElems.RemoveAt(listaElems.Count-1);
            return elem;
        }

        public Comparable peek()
        {
            if (listaElems.Count == 0) return null;
            return listaElems[listaElems.Count - 1];
        }

        // implementacion coleccionable
        public int cuantos()
        {
            return listaElems.Count;
        }

        public Comparable minimo()
        {
            Comparable minimo = listaElems[0];
            for (int i = 1; i < listaElems.Count; i++)
            {
                if (listaElems[i].sosMenor(minimo)) { minimo = listaElems[i]; }
            }
            return minimo;
        }

        public Comparable maximo()
        {
            Comparable maximo = listaElems[0];
            for (int i = 1; i < listaElems.Count; i++)
            {
                if (listaElems[i].sosMayor(maximo)) { maximo = listaElems[i]; }
            }
            return maximo;
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable elem in listaElems)
            {
                if (elem.sosIgual(c)) { return true; }
            }
            return false;
        }
    }
}
