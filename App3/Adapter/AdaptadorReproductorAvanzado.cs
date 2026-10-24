using System;

namespace App3.Adapter
{
    public class AdaptadorReproductorAvanzado : IReproductor
    {
        // ATT
        private IExterna reproductor;

        // Constructor
        public AdaptadorReproductorAvanzado(IExterna reproductor)
        {
            this.reproductor = reproductor;
        }

        // Meth
        public void reproducir(string archivo)
        {
            if (archivo.EndsWith(".avi"))
            {
                reproductor.reproducirArchivoAvi(archivo);
            }
            else if (archivo.EndsWith(".mp4"))
            {
                reproductor.reproducirArchivoMp4(archivo);
            }
        }
    }
}
