using Practica4;
using Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ServicioDeAlumnosConCache : IServicioDeAlumnos
    {
        private IServicioDeAlumnos servicioReal;
        private Dictionary<int, Alumno> cache = new Dictionary<int, Alumno>();

        public ServicioDeAlumnosConCache(IServicioDeAlumnos servicioReal)
        {
            this.servicioReal = servicioReal;
        }

        public Alumno buscarAlumno(int legajo)
        {
            if (cache.ContainsKey(legajo))
                return cache[legajo];

            Alumno alumno = servicioReal.buscarAlumno(legajo);

            if (alumno != null)
                cache.Add(legajo, alumno);

            return alumno;
        }
    }
}
