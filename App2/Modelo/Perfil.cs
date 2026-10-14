using System;
using System.Collections.Generic;
using System.Text;
using App2.interfaces;

namespace App2.Modelo
{
    public abstract class Perfil: Comparable
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
        public virtual bool sosIgual(Comparable otro)
        {
            Perfil obj = (Perfil)otro;
            return obj.getId() == id;
        }

        public virtual bool sosMenor(Comparable otro)
        {
            Perfil obj = (Perfil)otro;
            return id < obj.getId();
        }

        public virtual bool sosMayor(Comparable otro)
        {
            Perfil obj = (Perfil)otro;
            return id > obj.getId();
        }
    }
}
