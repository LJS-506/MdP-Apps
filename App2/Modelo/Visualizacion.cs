using System;
using System.Collections.Generic;
using System.Text;
using App2.interfaces;

namespace App2.Modelo
{
    public class Visualizacion : Comparable
    {
        // ATT
        private int cantidad;

        // Construct
        public Visualizacion(int c)
        {
            this.cantidad = c;
        }

        // Meth
        public int getCantidad()
        {
            return cantidad;
        }
        public override string ToString()
        {
            return cantidad.ToString();
        }

        //Implementacion comparable
        public bool sosIgual(Comparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return obj.getCantidad() == cantidad;
        }

        public bool sosMayor(Comparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return  cantidad  > obj.getCantidad();
        }

        public bool sosMenor(Comparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return cantidad < obj.getCantidad();
        }

    }
}
