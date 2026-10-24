using System;

namespace App3.Proxy
{
    public class Usuario
    {
        // ATT
        private string acceso;

        // Constructor
        public Usuario(string acceso)
        {
            this.acceso = acceso;
        }

        // Meth
        public string getAcceso()
        {
            return acceso;
        }
    }
}
