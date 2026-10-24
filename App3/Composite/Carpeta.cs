using System;
using System.Collections.Generic;

namespace App3.Composite
{
    public class Carpeta : IElementoSistemaArchivos
    {
        // ATT
        private string nombre;
        private List<IElementoSistemaArchivos> elementos;

        // Constructor
        public Carpeta(string nombre)
        {
            this.nombre = nombre;
            elementos = new List<IElementoSistemaArchivos>();
        }

        // Meth
        public void agregar(IElementoSistemaArchivos elemento)
        {
            elementos.Add(elemento);
        }

        // Implementacion IElementoSistemaArchivos
        public int obtenerTamano()
        {
            int tamano = 0;
            foreach (IElementoSistemaArchivos elemento in elementos)
            {
                tamano += elemento.obtenerTamano();
            }
            return tamano;
        }

        public void mostrar(int nivelDeIndentacion)
        {
            string indentacion = new string(' ', nivelDeIndentacion);
            Console.WriteLine($"{indentacion}{nombre} - {obtenerTamano()}");
            foreach (IElementoSistemaArchivos elemento in elementos)
            {
                elemento.mostrar(nivelDeIndentacion + 4);
            }
        }
    }
}
