using System;
using System.Collections.Generic;
using System.Text;
using App1.interfaces;
using App1.Modelo;

namespace App1.orden
{
    internal class Pila: IColeccionable
    {
        // ATT
        private List<interfaces.Comparable> listaElems;

        // Construct
        public Pila()
        {
            listaElems = new List<interfaces.Comparable>();
        }

        // Meth
        public void agregar(interfaces.Comparable c)
        {
            listaElems.Add(c);
        }

        public interfaces.Comparable desapilar()
        {
            if (listaElems.Count == 0)
            {
                return null;
            }
            interfaces.Comparable elem = listaElems[listaElems.Count-1];
            listaElems.RemoveAt(listaElems.Count-1);
            return elem;
        }

        public interfaces.Comparable peek()
        {
            if (listaElems.Count == 0) return null;
            return listaElems[listaElems.Count - 1];
        }

        // implementacion coleccionable
        public int cuantos()
        {
            return listaElems.Count;
        }

        public interfaces.Comparable minimo()
        {
            interfaces.Comparable minimo = listaElems[0];
            for (int i = 1; i < listaElems.Count; i++)
            {
                if (listaElems[i].sosMenor(minimo)) { minimo = listaElems[i]; }
            }
            return minimo;
        }

        public interfaces.Comparable maximo()
        {
            interfaces.Comparable maximo = listaElems[0];
            for (int i = 1; i < listaElems.Count; i++)
            {
                if (listaElems[i].sosMayor(maximo)) { maximo = listaElems[i]; }
            }
            return maximo;
        }

        public bool contiene(interfaces.Comparable c)
        {
            foreach (interfaces.Comparable elem in listaElems)
            {
                if (elem.sosIgual(c)) { return true; }
            }
            return false;
        }
    }
}
