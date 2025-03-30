using System;

namespace Ejercicios
{
	public interface Coleccionable
	{
		//ejercicio 03
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
		
	}
}
