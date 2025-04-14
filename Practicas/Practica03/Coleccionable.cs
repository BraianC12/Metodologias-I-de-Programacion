using System;

namespace Practica03
{
	public interface Coleccionable: Iterable
	{
		//ejercicio 03
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
}
