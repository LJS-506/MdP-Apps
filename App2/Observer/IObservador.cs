using System;
using System.Collections.Generic;
using System.Text;
using App2.Modelo;

namespace App2.Observer
{
    public interface IObservador
    {
    }

    public interface IObservadorDeCanales : IObservador
    {
        void actualizarContent(Canal t);
        void actualizarNoti(Canal t);
    }
}
