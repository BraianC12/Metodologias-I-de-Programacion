using System;

namespace Practica06
{
	public class ComPorPromedio: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a, IAlumno b){
			return a.getPromedio()==b.getPromedio();
		}
		
		public bool sosMenor(IAlumno a, IAlumno b){
			return a.getPromedio()<b.getPromedio();
		}
		
		public bool sosMayor(IAlumno a, IAlumno b){
			return a.getPromedio()>b.getPromedio();
		}
	}
}
