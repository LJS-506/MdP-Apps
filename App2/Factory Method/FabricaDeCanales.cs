using App2.interfaces;
using App2.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Factory_Method
{
    internal class FabricaDeCanales:FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Canal(generador.stringAleatorio(6));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos generador = new LectorDeDatos();
            return new Canal(generador.stringPorTeclado());
        }
    }
}
