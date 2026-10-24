using System;

namespace App3.Proxy
{
    public class DocumentoProxy : IDocumento
    {
        // ATT
        private DocumentoReal? documento = null;
        private string nombre;

        // Constructor
        public DocumentoProxy(string nombre)
        {
            this.nombre = nombre;
        }

        // Meth
        public string getNombre()
        {
            return nombre;
        }

        public string leer(Usuario usuario)
        {
            if (usuario.getAcceso() == "admin")
            {
                if (documento == null)
                {
                    documento = new DocumentoReal(nombre);
                }
                return documento.leer(usuario);
            }
            return "Acceso denegado.";
        }
    }
}
