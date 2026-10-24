using System;
using System.Collections.Generic;
using System.Text;
using App2.Modelo;

namespace App2.Decorator
{
    public abstract class DecoradorSuscriptor : Mostrable
    {
        protected Mostrable componente;
        public DecoradorSuscriptor(Mostrable componente)
        {
            this.componente = componente;
        }
        public abstract string mostrarInfo();
        public Suscriptor GetSuscriptor()
        {
            return componente.GetSuscriptor();
        }
    }

    public class DecoradorAntiguedad : DecoradorSuscriptor
    {
        public DecoradorAntiguedad(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            string texto = componente.mostrarInfo();
            int meses = componente.GetSuscriptor().getMesesDeSuscripcion();
            int posicion = texto.LastIndexOf(" - ");

            return texto.Insert(posicion, $" (Suscriptor hace {meses} meses)");
        }
    }

    public class DecoradorFanatismo : DecoradorSuscriptor
    {
        public DecoradorFanatismo(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            int horas = componente.GetSuscriptor().getHorasVistas();

            string nivel = horas >= 50 ? "Oro"
                         : horas >= 10 ? "Plata"
                         : "Bronce";

            return $"[{nivel}] {componente.mostrarInfo()}";
        }
    }

    public class DecoradorActivo : DecoradorSuscriptor
    {
        public DecoradorActivo(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            string texto = componente.mostrarInfo();
            string estado = componente.GetSuscriptor().getHorasVistas() > 0 ? "Cuenta Activa":"Cuenta Inactiva";

            int cierre = texto.IndexOf(')');

            if (cierre >= 0)
                return texto.Insert(cierre, $", {estado}");

            int separador = texto.LastIndexOf(" - ");
            return texto.Insert(separador, $" ({estado})");
        }
    }

    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            string texto = componente.mostrarInfo();
            string borde = new string('*', texto.Length + 4);

            return $"{borde}\n* {texto} *\n{borde}";
        }
    }
}
