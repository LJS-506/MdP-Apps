using Practica4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ListaDeInscriptos
    {
        private List<Alumno> alumnos = new List<Alumno>();
        private EstrategiaDeBusqueda estrategia;

        public ListaDeInscriptos(EstrategiaDeBusqueda estrategia)
        {
            this.estrategia = estrategia;
        }

        public void cargar(int n)
        {
            alumnos.Clear();

            for (int i = 1; i <= n; i++)
                alumnos.Add(new Alumno(i, "Alumno " + i));
        }

        public void setEstrategia(EstrategiaDeBusqueda nuevaEstrategia)
        {
            estrategia = nuevaEstrategia;
        }

        public Alumno buscar(int legajo)
        {
            return estrategia.Buscar(alumnos, legajo);
        }
    }
}
