
using System;

namespace Practica03
{
		
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(Comparable a, Comparable b);
		bool sosMenor(Comparable a, Comparable b);
		bool sosMayor(Comparable a, Comparable b);
			
	}
}
