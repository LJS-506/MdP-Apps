using System;

namespace App3.ChainOfResponsibility
{
    public abstract class AprobadorDeGastos
    {
        // ATT
        protected AprobadorDeGastos? sucesor = null;

        // Meth
        public void setSucesor(AprobadorDeGastos sucesor)
        {
            this.sucesor = sucesor;
        }

        public virtual void aprobar(SolicitudDeGasto solicitud)
        {
            if (sucesor != null)
            {
                sucesor.aprobar(solicitud);
            }
            else
            {
                Console.WriteLine("Nadie pudo aprobar la solicitud: " + solicitud.getDescripcion());
            }
        }
    }
}
