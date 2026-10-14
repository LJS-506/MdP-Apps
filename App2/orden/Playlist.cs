using App2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.orden
{
    public class Playlist
    {
        HashSet<IColeccionable> elems = new HashSet<IColeccionable>();

        public void agregar(IColeccionable elem)
        {
            elems.Add(elem);
        }

        public bool pertenece(IColeccionable elem)
        {
            return elems.Contains(elem);
        }
    }
}
