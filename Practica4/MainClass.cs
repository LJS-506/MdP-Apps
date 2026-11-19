using Iterativos;
using Recursivos;
using Strategy;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica4
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
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

        public static void ejercicio2()
        {
            int[] n = { 5, 10, 20, 25 };
            foreach (int num in n)
            {
                Contador.reiniciar();
                int resultado1 = AlgoritmosRecursivos.rec1(num);
                long llamadas1 = Contador.getOperaciones();

                Contador.reiniciar();
                int resultado2 = AlgoritmosRecursivos.rec2(num);
                long llamadas2 = Contador.getOperaciones();

                long formula1 = AlgoritmosRecursivos.formulaRec1(num);
                long formula2 = AlgoritmosRecursivos.formulaRec2(num);
                long ganancia = llamadas1 / llamadas2;

                Console.WriteLine($"n = {num}");
                Console.WriteLine($"rec1 = {resultado1}, rec2 = {resultado2}\n" +   
                    $"Mismo resultado? {resultado1 == resultado2}\n" +
                    $"Llamadas de rec1: {llamadas1}, Fórmula: {formula1}\n" +
                    $"Llamadas de rec2: {llamadas2}, Fórmula: {formula2}\n" +
                    $"Ganancia: {ganancia}");
                Console.WriteLine();
            }
        }

        public static void ejercicio3()
        {
            int[] tamanios = { 1000, 10000, 100000, 1000000 };

            foreach (int n in tamanios)
            {
                ListaDeInscriptos lista = new ListaDeInscriptos(new BusquedaLineal());
                lista.cargar(n);
                int legajoBuscado = n + 1;

                Contador.reiniciar();
                lista.buscar(legajoBuscado);
                long comparacionesLineal = Contador.getOperaciones();

                lista.setEstrategia(new BusquedaBinaria());

                Contador.reiniciar();
                lista.buscar(legajoBuscado);
                long comparacionesBinaria = Contador.getOperaciones();

                long ganancia = comparacionesLineal / comparacionesBinaria;

                Console.WriteLine($"n = {n}, Estrategia Lineal = {comparacionesLineal} / " +
                                  $"Estrategia Binaria = {comparacionesBinaria}, Ganancia = {ganancia}");
            }
        }
    }
}