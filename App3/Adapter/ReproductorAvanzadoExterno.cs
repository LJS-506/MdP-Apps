using System;

namespace App3.Adapter
{
    public class ReproductorAvanzadoExterno : IExterna
    {
        public void reproducirArchivoAvi(string archivo)
        {
            Console.WriteLine($"Reproduciendo archivo AVI: {archivo}");
        }

        public void reproducirArchivoMp4(string archivo)
        {
            Console.WriteLine($"Reproduciendo archivo MP4: {archivo}");
        }
    }
}
