using System;

namespace App3.Proxy
{
    public class DocumentoReal : IDocumento
    {
        // ATT
        private string contenido = "Este documento contiene el resumen del proyecto de patrones de diseño.";

        // Constructor
        public DocumentoReal()
        {
            Console.WriteLine("Cargando documento...");
        }

        // Meth
        public string getContenido()
        {
            return contenido;
        }

        // Implementacion IDocumento
        public string leer(Usuario usuario)
        {
            if (usuario.getAcceso() == "admin")
            {
                return getContenido();
            }
            return "Acceso denegado.";
        }
    }
}
