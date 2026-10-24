namespace App3.Command
{
    public class ComandoApagarLuz : IComando
    {
        // ATT
        private luz receptor;

        // Constructor
        public ComandoApagarLuz(luz receptor)
        {
            this.receptor = receptor;
        }

        // Implementacion IComando
        public void ejecutar()
        {
            receptor.apagar();
        }

        public void deshacer()
        {
            receptor.encender();
        }
    }
}
