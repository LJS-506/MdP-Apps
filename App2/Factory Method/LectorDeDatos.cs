using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Factory_Method
{
    internal class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un texto: ");
            return Console.ReadLine();
        }
    }
}
