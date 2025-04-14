using System;

namespace Practica03
{
	public class ComPorPromedio: EstrategiaDeComparacion
	{
		public bool sosIgual(Comparable a, Comparable b){
			return ((Alumno)a).getPromedio()==((Alumno)b).getPromedio();
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			return ((Alumno)a).getPromedio()<((Alumno)b).getPromedio();
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			return ((Alumno)a).getPromedio()>((Alumno)b).getPromedio();
		}
	}
}
