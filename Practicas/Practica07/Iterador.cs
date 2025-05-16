using System;

namespace Practica07
{
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
