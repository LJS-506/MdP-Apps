namespace App3.ChainOfResponsibility
{
    public class SolicitudDeGasto
    {
        // ATT
        private string descripcion;
        private double monto;

        // Constructor
        public SolicitudDeGasto(string descripcion, double monto)
        {
            this.descripcion = descripcion;
            this.monto = monto;
        }

        // Meth
        public string getDescripcion()
        {
            return descripcion;
        }

        public double getMonto()
        {
            return monto;
        }
    }
}
