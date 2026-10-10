using App1.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.orden
{
    internal class Cola: IColeccionable
    {
        // ATT
        private List<interfaces.Comparable> listaElems;

        // Constructor
        public Cola()
        {
            listaElems = new List<interfaces.Comparable>();
        }


        // Meth
        public void agregar(interfaces.Comparable c)
        {
            listaElems.Add(c);
        }

        public interfaces.Comparable desencolar()
        {
            if (listaElems.Count == 0) {return null;}
            interfaces.Comparable elem = listaElems[0];
            listaElems.RemoveAt(0);
            return elem;
        }

        public interfaces.Comparable peek()
        {
            return listaElems[0];
        }

        // implementacion coleccionable
        public int cuantos()
        {
            return listaElems.Count;
        }

        public interfaces.Comparable minimo()
        {
            interfaces.Comparable minimo = listaElems[0];
            for (int i=1; i<listaElems.Count; i++)
            {
                if (listaElems[i].sosMenor(minimo)) {minimo = listaElems[i];}
            }
            return minimo;
        }
        
        public interfaces.Comparable maximo()
        {
            interfaces.Comparable maximo = listaElems[0];
            for (int i=1; i<listaElems.Count; i++)
            {
                if (listaElems[i].sosMayor(maximo)) {maximo = listaElems[i];}
            }
            return maximo;
        }

        public bool contiene(interfaces.Comparable c)
        {
            foreach (interfaces.Comparable elem in listaElems)
            {
                if (elem.sosIgual(c)) {return true;}
            }
            return false;
        }
    }
}
