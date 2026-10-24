using System;

namespace App3.Command
{
    public class luz
    {
        // ATT
        private string estado = "Apagada";

        // Meth
        public void encender()
        {
            estado = "Encendida";
            Console.WriteLine(estado);
        }

        public void apagar()
        {
            estado = "Apagada";
            Console.WriteLine(estado);
        }
    }
}
