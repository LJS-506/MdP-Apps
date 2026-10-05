// See https://aka.ms/new-console-template for more information
using App1.interfaces;
using App1.Modelo;

Console.WriteLine("Hello, World!");


static void llenar(IColeccionable coleccion)
{
    Random rnd = new Random();
    for (int i=0; i<20; i++)
    {
        int randomVis = rnd.Next(1, 1000000);
        coleccion.agregar(new Visualizacion(randomVis));
    }
}