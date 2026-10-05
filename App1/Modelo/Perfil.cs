using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Modelo
{
    abstract class Perfil: interfaces.IComparable
    {
        // ATT
        private string nombre;
        private int id;

        // Constructor
        public Perfil(string n, int i)
        {
            this.nombre = n;
            this.id = i;
        }

        // Meth
        public string getNombre()
        { return nombre;}

        public int getId()
        { return id;}

        // Implementacion comparable
        public bool sosIgual(interfaces.IComparable otro)
        {
            Perfil obj = (Perfil)otro;
            return obj.getId() == id;
        }

        public bool sosMenor(interfaces.IComparable otro)
        {
            Perfil obj = (Perfil)otro;
            return id < obj.getId();
        }

        public bool sosMayor(interfaces.IComparable otro)
        {
            Perfil obj = (Perfil)otro;
            return id > obj.getId();
        }
    }
}
