using System;
using System.Collections.Generic;
using System.Text;
using Practica4;

namespace Strategy
{
    public interface EstrategiaDeBusqueda
    {
        Alumno Buscar(List<Alumno> alumnos, int legajo);
    }

    public class BusquedaLineal : EstrategiaDeBusqueda
    {
        public Alumno Buscar(List<Alumno> alumnos, int legajo)
        {
            foreach (Alumno alumno in alumnos)
            {
                Contador.sumar();

                if (alumno.getLegajo() == legajo)
                    return alumno;
            }

            return null;
        }
    }

    public class BusquedaBinaria : EstrategiaDeBusqueda
    {
        public Alumno Buscar(List<Alumno> alumnos, int legajo)
        {
            int inicio = 0;
            int fin = alumnos.Count - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;
                Alumno alumno = alumnos[medio];
                int legajoActual = alumno.getLegajo();
                Contador.sumar();

                if (legajoActual == legajo)
                    return alumno;

                if (legajoActual < legajo)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }

            return null;
        }
    }
}
