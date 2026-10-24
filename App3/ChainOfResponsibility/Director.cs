using System;

namespace App3.ChainOfResponsibility
{
    public class Director : AprobadorDeGastos
    {
        // Meth
        public override void aprobar(SolicitudDeGasto solicitud)
        {
            Console.WriteLine($"Director aprobó la solicitud: {solicitud.getDescripcion()} - ${solicitud.getMonto()}");
        }
    }
}
