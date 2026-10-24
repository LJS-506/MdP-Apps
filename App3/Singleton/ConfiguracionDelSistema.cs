using System.Collections.Generic;

namespace App3.Singleton
{
    public class ConfiguracionDelSistema
    {
        // ATT
        private static ConfiguracionDelSistema instancia = new ConfiguracionDelSistema();
        private Dictionary<string, string> valores;

        // Constructor
        private ConfiguracionDelSistema()
        {
            valores = new Dictionary<string, string>();
        }

        // Meth
        public static ConfiguracionDelSistema getInstacia()
        {
            return instancia;
        }

        public void establecerValor(string clave, string valor)
        {
            valores[clave] = valor;
        }

        public string obtenerValor(string clave)
        {
            return valores[clave];
        }
    }
}
