using System;

namespace App3.ChainOfResponsibility
{
    public class Supervisor : AprobadorDeGastos
    {
        // Meth
        public override void aprobar(SolicitudDeGasto solicitud)
        {
            if (solicitud.getMonto() <= 1000)
            {
                Console.WriteLine($"Supervisor aprobó la solicitud: {solicitud.getDescripcion()} - ${solicitud.getMonto()}");
            }
            else
            {
                base.aprobar(solicitud);
            }
        }
    }
}
