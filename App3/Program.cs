
using App3.Adapter;

public class Program
{
    public static void Main()
    {
        ReproductorMp3 reproductorMp3 = new ReproductorMp3();
        ReproductorAvanzadoExterno reproductorExterno = new ReproductorAvanzadoExterno();
        AdaptadorReproductorAvanzado adaptador = new AdaptadorReproductorAvanzado(reproductorExterno);

        ReproducirArchivo(reproductorMp3, "cancion.mp3");
        ReproducirArchivo(adaptador, "pelicula.avi");
        ReproducirArchivo(adaptador, "video.mp4");
    }

    public static void ReproducirArchivo(IReproductor reproductor, string archivo)
    {
        reproductor.reproducir(archivo);
    }
}
