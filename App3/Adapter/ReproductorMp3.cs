using System;

namespace App3.Adapter
{
    public class ReproductorMp3 : IReproductor
    {
        public void reproducir(string archivo)
        {
            Reproducir(archivo);
        }

        public void Reproducir(string archivo)
        {
            Console.WriteLine($"Reproduciendo archivo MP3: {archivo}");
        }
    }
}
