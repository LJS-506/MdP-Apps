namespace App3.Command
{
    public class ControlRemoto
    {
        // ATT
        private IComando? ultimoComando = null;

        // Meth
        public void ejecutar(IComando comando)
        {
            comando.ejecutar();
            ultimoComando = comando;
        }

        public void deshacerUltimo()
        {
            if (ultimoComando != null)
            {
                ultimoComando.deshacer();
            }
        }
    }
}
