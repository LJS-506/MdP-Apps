
using App3.Adapter;
using App3.ChainOfResponsibility;
using App3.Command;
using App3.Composite;
using App3.Proxy;
using App3.Singleton;
using App3.TemplateMethod;

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
    /*
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
    */

    // Composite
    /*
    public static void Main()
    {
        Carpeta raiz = new Carpeta("Raiz");
        Carpeta documentos = new Carpeta("Documentos");
        Carpeta imagenes = new Carpeta("Imagenes");

        documentos.agregar(new Archivo("informe.txt", 100));
        documentos.agregar(new Archivo("apuntes.txt", 200));

        imagenes.agregar(new Archivo("foto1.jpg", 300));
        imagenes.agregar(new Archivo("foto2.jpg", 400));

        raiz.agregar(documentos);
        raiz.agregar(imagenes);

        raiz.mostrar(0);
        Console.WriteLine("Tamaño total: " + raiz.obtenerTamano());
    }
    */

    // Template Method
    /*
    public static void Main()
    {
        PreparadorDeCafe cafe = new PreparadorDeCafe();
        PreparadorDeTe te = new PreparadorDeTe();

        Console.WriteLine("-- Café --");
        cafe.prepararBebida();

        Console.WriteLine("\n-- Té --");
        te.prepararBebida();
    }
    */

    // Chain of Responsibility
    /*
    public static void Main()
    {
        Supervisor supervisor = new Supervisor();
        Gerente gerente = new Gerente();
        Director director = new Director();

        supervisor.setSucesor(gerente);
        gerente.setSucesor(director);

        Console.WriteLine("-- Cadena completa --");
        supervisor.aprobar(new SolicitudDeGasto("Compra de útiles", 500));
        supervisor.aprobar(new SolicitudDeGasto("Límite del supervisor", 1000));
        supervisor.aprobar(new SolicitudDeGasto("Supera el límite del supervisor", 1001));
        supervisor.aprobar(new SolicitudDeGasto("Límite del gerente", 5000));
        supervisor.aprobar(new SolicitudDeGasto("Supera el límite del gerente", 5001));
        supervisor.aprobar(new SolicitudDeGasto("Compra de equipamiento", 10000));

        Supervisor supervisorSinDirector = new Supervisor();
        Gerente gerenteSinDirector = new Gerente();
        supervisorSinDirector.setSucesor(gerenteSinDirector);

        Console.WriteLine("\n-- Cadena incompleta: Supervisor -> Gerente --");
        supervisorSinDirector.aprobar(new SolicitudDeGasto("Compra de equipamiento sin director", 10000));
    }
    */

    // Singleton
    public static void Main()
    {
        ConfiguracionDelSistema configuracion1 = ConfiguracionDelSistema.getInstacia();
        ConfiguracionDelSistema configuracion2 = obtenerConfiguracion();

        configuracion1.establecerValor("idioma", "Español");

        Console.WriteLine("Valor leído desde la segunda referencia: " + configuracion2.obtenerValor("idioma"));
        Console.WriteLine("Ambas referencias apuntan a la misma instancia: " + object.ReferenceEquals(configuracion1, configuracion2));
    }

    public static ConfiguracionDelSistema obtenerConfiguracion()
    {
        return ConfiguracionDelSistema.getInstacia();
    }



}
