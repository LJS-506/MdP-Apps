using System;

namespace App3.TemplateMethod
{
    public class PreparadorDeCafe : PreparadorDeBebida
    {
        // Meth
        protected override void agregarBaseDeSaborizante()
        {
            Console.WriteLine("Agregando café");
        }
    }
}
