using System;

namespace App3.Command
{
    public interface IComando
    {
        void ejecutar();
        void deshacer();
    }
}
