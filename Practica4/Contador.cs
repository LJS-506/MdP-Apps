using System;

namespace Practica4
{
	public static class Contador
	{
		private static long cantidad;

		public static void sumar() { cantidad++; }

		public static long getOperaciones() { return cantidad;}

		public static void reiniciar() { cantidad = 0;}
    }
}