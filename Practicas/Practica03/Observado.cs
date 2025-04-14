using System;

namespace Practica03
{
	/// <summary>
	/// Description of Observado.
	/// </summary>
	public interface Observado
	{
		//ejercicio12
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
		
	}
}
