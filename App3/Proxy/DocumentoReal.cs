using System;

namespace App3.Proxy
{
    public class DocumentoReal : IDocumento
    {
        // ATT
        private string nombre;
        private string contenido = "Los patrones de diseño permiten organizar las responsabilidades de un programa " +
            "y resolver problemas que aparecen con frecuencia durante el desarrollo de software. Cada patrón " +
            "describe una forma de relacionar objetos y clases para facilitar la comprensión y la modificación del código.\n\n" +
            "El patrón Adapter permite que dos interfaces diferentes trabajen juntas. En este proyecto, un adaptador " +
            "recibe pedidos de reproducción mediante IReproductor y los transforma en llamadas al reproductor externo, " +
            "según la extensión del archivo recibido. De esta manera, el programa puede utilizar distintos formatos " +
            "a través de una misma interfaz.\n\n" +
            "El patrón Proxy utiliza un objeto intermediario para controlar el acceso a otro objeto. El intermediario " +
            "verifica los permisos del usuario antes de crear el documento real. Si el usuario tiene acceso de administrador, " +
            "el documento se carga durante la primera lectura y se conserva para las siguientes consultas.\n\n" +
            "Esta creación diferida evita cargar documentos que todavía no se necesitan. Además, mantener el control " +
            "de acceso en el proxy permite separar la autorización de la responsabilidad de almacenar y devolver " +
            "el contenido del documento.";

        // Constructor
        public DocumentoReal(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine("Cargando documento...");
        }

        // Implementacion IDocumento
        public string leer(Usuario usuario)
        {
            return contenido;
        }
    }
}
