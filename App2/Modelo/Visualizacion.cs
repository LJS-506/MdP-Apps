using System;
using System.Collections.Generic;
using System.Text;
using App2.interfaces;

namespace App2.Modelo
{
    public class Visualizacion : interfaces.Comparable
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
        public bool sosIgual(interfaces.Comparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return obj.getCantidad() == cantidad;
        }

        public bool sosMayor(interfaces.Comparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return  cantidad  > obj.getCantidad();
        }

        public bool sosMenor(interfaces.Comparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return cantidad < obj.getCantidad();
        }

    }
}
