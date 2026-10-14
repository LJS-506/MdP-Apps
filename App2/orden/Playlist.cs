using App2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.orden
{
    public class Playlist : IColeccionable
    {
        List<Comparable> listaElems = new List<Comparable>();

        public void agregar(Comparable  elem)
        {
            if (!pertenece(elem))
            {
                listaElems.Add(elem);
            }
        }

        public bool pertenece(Comparable c)
        {
            foreach (Comparable elem in listaElems)
            {
                if (c.sosIgual(elem)) { return true; }
            }
            return false;
        }

        // Implementacion Coleccionable
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
            return listaElems.Contains(c);
        }
    }
}
