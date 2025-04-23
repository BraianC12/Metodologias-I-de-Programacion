
using System;

namespace Practica04
{
		
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(IAlumno a, IAlumno b);
		bool sosMenor(IAlumno a, IAlumno b);
		bool sosMayor(IAlumno a, IAlumno b);
	}
}
