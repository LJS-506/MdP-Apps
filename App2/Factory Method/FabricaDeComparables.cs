using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using App2.interfaces;

namespace App2.Factory_Method
{
    public abstract class FabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = obtenerFabrica(opcion);
            if (fabrica == null) { return null; }
            return fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = obtenerFabrica(opcion);
            if (fabrica == null) { return null;}
            return fabrica.crearPorTeclado();
        }

        // Método para elegir que fabrica usar
        public static FabricaDeComparables obtenerFabrica(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return new FabricaDeVisualizaciones();
                case 2:
                    return new FabricaDeSuscriptores();
                default:
                    Console.WriteLine("Opción inválida");
                    return null;
            }
        }

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}
