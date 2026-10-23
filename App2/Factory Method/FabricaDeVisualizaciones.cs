using System;
using System.Collections.Generic;
using System.Text;
using App2.interfaces;
using App2.Modelo;

namespace App2.Factory_Method
{
    public class FabricaDeVisualizaciones: FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Visualizacion(generador.numeroAleatorio(1000000));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos generador = new LectorDeDatos();
            return new Visualizacion(generador.numeroPorTeclado());
        }
    }
}
