using App2.interfaces;
using App2.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Factory_Method
{
    public class FabricaDeSuscriptores: FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Suscriptor(generador.stringAleatorio(10), generador.numeroAleatorio(100000000), generador.numeroAleatorio(121), generador.numeroAleatorio(10000));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos generador = new LectorDeDatos();
            return new Suscriptor(generador.stringPorTeclado(), generador.numeroPorTeclado(), generador.numeroPorTeclado(), generador.numeroPorTeclado());
        }
    }
}
