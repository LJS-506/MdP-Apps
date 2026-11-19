using Iterativos;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica4
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ejercicio1();
        }

        public static void ejercicio1()
        {
            int[] n = { 10, 100, 1000 };

            foreach(int num in n)
            {
                Contador.reiniciar();
                AlgoritmosIterativos.contar(num);
                string coinciden = Contador.getOperaciones() == AlgoritmosIterativos.formulaContar(num) ? "Sí" : "No";
                Console.WriteLine($"contar, n={num}, " +
                    $"Operaciones contadas={Contador.getOperaciones()}, " +
                    $"Valor fórmula={AlgoritmosIterativos.formulaContar(num)}, " +
                    $"Coinciden? {coinciden}, O(n)");

                
                Contador.reiniciar();
                AlgoritmosIterativos.contar2(num);
                coinciden = Contador.getOperaciones() == AlgoritmosIterativos.formulaContar2(num) ? "Sí" : "No";
                Console.WriteLine($"contar2, n={num}, " +
                    $"Operaciones contadas={Contador.getOperaciones()}, " +
                    $"Valor fórmula={AlgoritmosIterativos.formulaContar2(num)}, " +
                    $"Coinciden? {coinciden}, O(n²)");

                
                Contador.reiniciar();
                AlgoritmosIterativos.contarDependiente(num);
                coinciden = Contador.getOperaciones() == AlgoritmosIterativos.formulaDependiente(num) ? "Sí" : "No";
                Console.WriteLine($"contarDependiente, n={num}, " +
                    $"Operaciones contadas={Contador.getOperaciones()}, " +
                    $"Valor fórmula={AlgoritmosIterativos.formulaDependiente(num)}, " +
                    $"Coinciden? {coinciden}, O(n²)");

                
                Contador.reiniciar();
                AlgoritmosIterativos.tiempoWhile(num);
                coinciden = Contador.getOperaciones() == AlgoritmosIterativos.formulaWhile(num) ? "Sí" : "No";
                Console.WriteLine($"tiempo, n={num}, " +
                    $"Operaciones contadas={Contador.getOperaciones()}, " +
                    $"Valor fórmula={AlgoritmosIterativos.formulaWhile(num)}, " +
                    $"Coinciden? {coinciden}, O(log n)");
                Console.WriteLine();
            }

        }

    }
}