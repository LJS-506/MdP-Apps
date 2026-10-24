using System;

namespace App3.TemplateMethod
{
    public class PreparadorDeTe : PreparadorDeBebida
    {
        // Meth
        protected override void agregarBaseDeSaborizante()
        {
            Console.WriteLine("Agregando té");
        }

        protected override void agregarCondimentos()
        {
            Console.WriteLine("Agregando miel y limón");
        }
    }
}
