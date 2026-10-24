namespace App3.Command
{
    public class ComandoEncenderLuz : IComando
    {
        // ATT
        private luz receptor;

        // Constructor
        public ComandoEncenderLuz(luz receptor)
        {
            this.receptor = receptor;
        }

        // Implementacion IComando
        public void ejecutar()
        {
            receptor.encender();
        }

        public void deshacer()
        {
            receptor.apagar();
        }
    }
}
