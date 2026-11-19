using System;
using System.Collections.Generic;
using System.Text;
using Practica4;

namespace Proxy
{
    public interface IServicioDeAlumnos
    {
        public Alumno buscarAlumno(int legajo);
    }
}
