using System;

namespace App3.Composite
{
    public class Archivo : IElementoSistemaArchivos
    {
        // ATT
        private string nombre;
        private int tamanofijo;

        // Constructor
        public Archivo(string nombre, int tamanofijo)
        {
            this.nombre = nombre;
            this.tamanofijo = tamanofijo;
        }

        // Implementacion IElementoSistemaArchivos
        public int obtenerTamano()
        {
            return tamanofijo;
        }

        public void mostrar(int nivelDeIndentacion)
        {
            string indentacion = new string(' ', nivelDeIndentacion);
            Console.WriteLine($"{indentacion}{nombre} - {tamanofijo}");
        }
    }
}
