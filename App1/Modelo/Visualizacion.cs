using System;
using System.Collections.Generic;
using System.Text;
using App1.interfaces;

namespace App1.Modelo
{
    public class Visualizacion : interfaces.IComparable
    {
        // ATT
        private int cantidad { get; }

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
        public bool sosIgual(interfaces.IComparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return obj.getCantidad() == cantidad;
        }

        public bool sosMayor(interfaces.IComparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return  cantidad  > obj.getCantidad();
        }

        public bool sosMenor(interfaces.IComparable otro)
        {
            Visualizacion obj = (Visualizacion)otro;
            return cantidad < obj.getCantidad();
        }

    }
}
