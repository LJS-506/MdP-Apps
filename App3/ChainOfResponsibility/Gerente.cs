using System;

namespace App3.ChainOfResponsibility
{
    public class Gerente : AprobadorDeGastos
    {
        // Meth
        public override void aprobar(SolicitudDeGasto solicitud)
        {
            if (solicitud.getMonto() <= 5000)
            {
                Console.WriteLine($"Gerente aprobó la solicitud: {solicitud.getDescripcion()} - ${solicitud.getMonto()}");
            }
            else
            {
                base.aprobar(solicitud);
            }
        }
    }
}
