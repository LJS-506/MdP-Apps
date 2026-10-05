using App1.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.orden
{
    internal class Cola: IColeccionable
    {
        // ATT
        private List<interfaces.IComparable> listaElems;

        // Construct
        public Cola()
        {
            foreach(interfaces.IComparable elem in listaElems)
            { listaElems.Add(elem);}
        }

        // Meth
        public void agregar(interfaces.IComparable c)
        {
            listaElems.Add(c);
        }

        public interfaces.IComparable desencolar()
        {
            if (listaElems.Count == 0) {return null;}
            interfaces.IComparable elem = listaElems[0];
            listaElems.RemoveAt(0);
            return elem;
        }

        public interfaces.IComparable peek()
        {
            return listaElems[0];
        }

        // implementacion coleccionable
        public int cuantos()
        {
            return listaElems.Count;
        }

        public interfaces.IComparable minimo()
        {
            interfaces.IComparable minimo = listaElems[0];
            for (int i=1; i<listaElems.Count; i++)
            {
                if (listaElems[i].sosMenor(minimo)) {minimo = listaElems[i];}
            }
            return minimo;
        }
        
        public interfaces.IComparable maximo()
        {
            interfaces.IComparable maximo = listaElems[0];
            for (int i=1; i<listaElems.Count; i++)
            {
                if (listaElems[i].sosMayor(maximo)) {maximo = listaElems[i];}
            }
            return maximo;
        }

        public bool contiene(interfaces.IComparable c)
        {
            foreach (interfaces.IComparable elem in listaElems)
            {
                if (elem.sosIgual(c)) {return true;}
            }
            return false;
        }
    }
}
