using System;
using System.Collections.Generic;
using System.Text;
using App1.interfaces;

namespace App1.orden
{
    internal class Pila: IColeccionable
    {
        // ATT
        private List<interfaces.IComparable> listaElems;

        // Construct
        public Pila()
        {
            listaElems = new List<interfaces.IComparable>();
        }

        // Meth
        public void agregar(interfaces.IComparable c)
        {
            listaElems.Add(c);
        }

        public interfaces.IComparable desapilar()
        {
            if (listaElems.Count == 0)
            {
                return null;
            }
            interfaces.IComparable elem = listaElems[listaElems.Count-1];
            listaElems.RemoveAt(listaElems.Count-1);
            return elem;
        }

        public interfaces.IComparable peek()
        {
            if (listaElems.Count == 0) return null;
            return listaElems[listaElems.Count - 1];
        }

        // implementacion coleccionable
        public int cuantos()
        {
            return listaElems.Count;
        }

        public interfaces.IComparable minimo()
        {
            interfaces.IComparable minimo = listaElems[0];
            for (int i = 1; i < listaElems.Count; i++)
            {
                if (listaElems[i].sosMenor(minimo)) { minimo = listaElems[i]; }
            }
            return minimo;
        }

        public interfaces.IComparable maximo()
        {
            interfaces.IComparable maximo = listaElems[0];
            for (int i = 1; i < listaElems.Count; i++)
            {
                if (listaElems[i].sosMayor(maximo)) { maximo = listaElems[i]; }
            }
            return maximo;
        }

        public bool contiene(interfaces.IComparable c)
        {
            foreach (interfaces.IComparable elem in listaElems)
            {
                if (elem.sosIgual(c)) { return true; }
            }
            return false;
        }
    }
}
