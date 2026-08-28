using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Visualizacion : Comparable
    {
        private int cantidad;

        public Visualizacion(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int getCantidad()
        {
            return cantidad;
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
