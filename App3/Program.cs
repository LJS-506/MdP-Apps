
using App3.Adapter;
using App3.Command;
using App3.Proxy;

public class Program
{
    // Adapter
    /*
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
    */

    // Proxy
    /*
    public static void Main()
    {
        Usuario usuarioSinPermiso = new Usuario("invitado");
        Usuario administrador1 = new Usuario("admin");
        Usuario administrador2 = new Usuario("admin");
        DocumentoProxy documento = new DocumentoProxy("Patrones de diseño");

        Console.WriteLine(documento.leer(usuarioSinPermiso));
        Console.WriteLine(documento.leer(administrador1));
        Console.WriteLine(documento.leer(administrador2));
    }
    */

    // Command
    public static void Main()
    {
        luz luzLiving = new luz();
        ControlRemoto controlRemoto = new ControlRemoto();

        controlRemoto.ejecutar(new ComandoEncenderLuz(luzLiving));
        controlRemoto.ejecutar(new ComandoApagarLuz(luzLiving));
        controlRemoto.ejecutar(new ComandoEncenderLuz(luzLiving));
        controlRemoto.ejecutar(new ComandoApagarLuz(luzLiving));

        controlRemoto.deshacerUltimo();
    }

}
