using System;
using System.Collections.Generic;
using System.Text;

namespace App1.interfaces
{
    public interface IComparable
    {
        bool sosIgual(IComparable otro);
        /*Devuelve v o f si el objeto que recibe el mensaje es el
        mismo que el "comparable" recibido por parámetro*/

        bool sosMenor(IComparable otro);
        /*Devuelve v o f si el objeto que recibe el mensaje es más
        chico que el "comparable" recibido por parámetro*/
        bool sosMayor(IComparable otro);
        /*Devuelve v o f si el objeto que recibe el mensaje es más
        grande que l "comparable" recibido por parámetro*/
    }
}