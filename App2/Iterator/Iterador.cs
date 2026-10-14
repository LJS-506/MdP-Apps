using App2.interfaces;
using App2.orden;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }

    public class IteradordeComparables : Iterador
    {
        private List<Comparable> listaComparables;
        private int indice;
        public IteradordeComparables(List<Comparable> lista)
        {
            this.listaComparables = lista;
            indice = 0;
        }
        public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice >= listaComparables.Count;
        }
        public Comparable actual()
        {
            return listaComparables[indice];
        }
    }
}
