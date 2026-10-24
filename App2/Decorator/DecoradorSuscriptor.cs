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
            return $"{componente.GetSuscriptor().getNombre()} (Suscriptor hace {componente.GetSuscriptor().getMesesDeSuscripcion()} meses) - {componente.GetSuscriptor().getHorasVistas()} horas vistas.";
        }
    }

    public class DecoradorFanatismo : DecoradorSuscriptor
    {
        public DecoradorFanatismo(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            if (componente.GetSuscriptor().getHorasVistas() >= 50)
            {
                return $"[Oro]{componente.GetSuscriptor().getNombre()} - {componente.GetSuscriptor().getHorasVistas()} horas vistas.";
            }
            if (componente.GetSuscriptor().getHorasVistas() >= 10 && componente.GetSuscriptor().getHorasVistas() < 50)
            {
                return $"[Plata]{componente.GetSuscriptor().getNombre()} - {componente.GetSuscriptor().getHorasVistas()} horas vistas.";
            }
            return $"[Bronce]{componente.GetSuscriptor().getNombre()} - {componente.GetSuscriptor().getHorasVistas()} horas vistas.";
        }
    }

    public class DecoradorActivo : DecoradorSuscriptor
    {
        public DecoradorActivo(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            if (componente.GetSuscriptor().getHorasVistas() > 0)
            {
                return $"{componente.GetSuscriptor().getNombre()} (Cuenta Activa)- {componente.GetSuscriptor().getHorasVistas()} horas vistas.";
            }
            return $"{componente.GetSuscriptor().getNombre()} (Cuenta Inactiva)- {componente.GetSuscriptor().getHorasVistas()} horas vistas.";
        }
    }

    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(Mostrable componente) : base(componente)
        {
        }
        public override string mostrarInfo()
        {
            return $"***************\n{componente.mostrarInfo()}\n***************";
        }
    }
}
