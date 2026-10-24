using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Observer
{
    public interface IObservado
    {
        void agregarObservador(IObservador obs);
        void notificarContenido();
        void notificarVivo();
    }
}
