using App1.interfaces;
using App1.Modelo;
using App1.orden;

public class Program
{
    public static void Main()
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        llenar(pila);
        llenar(cola);
        Console.WriteLine("-- Pila --");
        informar(pila);
        Console.WriteLine("-- Cola --");
        informar(cola);
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


