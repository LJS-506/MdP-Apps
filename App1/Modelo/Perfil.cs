using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Modelo
{
    abstract class Perfil: interfaces.Comparable
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
        public virtual bool sosIgual(interfaces.Comparable otro)
        {
            Perfil obj = (Perfil)otro;
            return obj.getId() == id;
        }

        public virtual bool sosMenor(interfaces.Comparable otro)
        {
            Perfil obj = (Perfil)otro;
            return id < obj.getId();
        }

        public virtual bool sosMayor(interfaces.Comparable otro)
        {
            Perfil obj = (Perfil)otro;
            return id > obj.getId();
        }
    }
}
