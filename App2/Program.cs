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
        llenarSuscriptores(pila);
        llenarSuscriptores(cola);
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
        for (int i = 0; i < 20; i++)
        {
            Suscriptor sus = new Suscriptor(
                nombreAleatorio(rnd),
                rnd.Next(100000000, 1000000000),
                rnd.Next(1, 121),
                rnd.Next(1, 10000));
            coleccion.agregar(sus);
        }
    }

    static string nombreAleatorio(Random rnd)
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string user = "user";
        for (int i = 0; i < 10; i++)
        { user += chars[rnd.Next(chars.Length)]; }
        return user;
    }

    static void informar(IColeccionable coleccion)
    {
        /* Falta implementar el patron de diseño que me permita alternar entre el tipo visualización y suscriptor, 
         * para poder informar correctamente de ambos tipos de colecciones. */
        try
        {
            Console.WriteLine("Cuantos: " + coleccion.cuantos());
            Console.WriteLine("Mínimo: " + coleccion.minimo());
            Console.WriteLine("Máximo: " + coleccion.maximo());
            Console.Write("Ingrese un valor a buscar en la colección: ");
            int valor = int.Parse(Console.ReadLine());
            Comparable vis = new Visualizacion(valor);
            if (coleccion.contiene(vis))
            {
                Console.WriteLine("El elemento leído está en la colección.\n");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección.\n");
            }
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("No se puede comparar, las colecciones son diferentes");
        }
        
    }
}


