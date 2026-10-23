using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Factory_Method
{
    public class GeneradorDeDatosAleatorios
    {
        private Random rnd = new Random();

        public int numeroAleatorio(int max)
        {
            return rnd.Next(0, max);
        }

        public string stringAleatorio(int cant)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string s = "user";
            for (int i = 0; i < cant; i++)
            { s += chars[rnd.Next(chars.Length)]; }
            return s;
        }
    }
}
