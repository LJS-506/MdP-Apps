interface Comparable
{
    bool sosIgual(Comparable otro);
/*Devuelve v o f si el objeto que recibe el mensaje es el
mismo que el "comparable" recibido por parámetro*/

    bool sosMayor(Comparable otro);
/*Devuelve v o f si el objeto que recibe el mensaje es más
chico que el "comparable" recibido por parámetro*/
    bool sosMenor(Comparable otro);
/*Devuelve v o f si el objeto que recibe el mensaje es más
grande que el "comparable" recibido por parámetro*/
}   