using System;

namespace Practica06
{
	/// <summary>
	/// Description of Observado.
	/// </summary>
	public interface Observado
	{
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
		
	}
}
