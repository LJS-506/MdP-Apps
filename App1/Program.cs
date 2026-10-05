using App1.interfaces;
using App1.Modelo;
using App1.orden;
using System.Text;

public class Program
{
    public static void Main()
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        Catalogo catalogo = new Catalogo(pila,cola);
        llenar(pila);
        llenar(cola);
        Console.WriteLine("-- Pila --");
        informar(pila);
        Console.WriteLine("-- Cola --");
        informar(cola);
        Console.WriteLine("-- Catalogo --");
        informar(catalogo);
    }

    static void llenar(IColeccionable coleccion)
    {
        Random rnd = new Random();
        for (int i = 0; i < 20; i++)
        {
            int randomVis = rnd.Next(1, 1000000);
            coleccion.agregar(new Visualizacion(randomVis));
        }
    }

    static void llenarSuscriptores(IColeccionable coleccion)
    {
        Random rnd = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string user = "user";
        for (int i = 0; i < 10; i++)
        { user += chars[rnd.Next(chars.Length)];}

        for (int i = 0; i < 20; i++)
        {
            Suscriptor sus = new Suscriptor(
                user,
                rnd.Next(100000000, 1000000000),
                rnd.Next(1, 121),
                rnd.Next(1, 10000));
            coleccion.agregar(sus);
        }
    }

    static void informar(IColeccionable coleccion)
    {
        Console.WriteLine("Cuantos: " + coleccion.cuantos());
        Console.WriteLine("Mínimo: " + coleccion.minimo());
        Console.WriteLine("Máximo: " + coleccion.maximo());
        Console.Write("Ingrese un valor a buscar en la colección: ");
        Visualizacion valor = new Visualizacion(int.Parse(Console.ReadLine()));
        if (coleccion.contiene(valor))
        {
            Console.WriteLine("El elemento leído está en la colección.\n");
        }
        else
        {
            Console.WriteLine("El elemento leído no está en la colección.\n");
        }
    }
}


