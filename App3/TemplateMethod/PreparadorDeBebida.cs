using System;

namespace App3.TemplateMethod
{
    public abstract class PreparadorDeBebida
    {
        // Meth
        public void prepararBebida()
        {
            hervirAgua();
            agregarBaseDeSaborizante();
            verterEnTaza();
            agregarCondimentos();
        }

        protected void hervirAgua()
        {
            Console.WriteLine("Hirviendo agua");
        }

        protected abstract void agregarBaseDeSaborizante();

        protected void verterEnTaza()
        {
            Console.WriteLine("Vertiendo en la taza");
        }

        protected virtual void agregarCondimentos()
        {
            Console.WriteLine("Agregando condimentos");
        }
    }
}
