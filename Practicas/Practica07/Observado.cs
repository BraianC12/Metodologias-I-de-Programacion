using System;

namespace Practica07
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
