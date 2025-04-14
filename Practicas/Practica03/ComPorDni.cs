using System;

namespace Practica03
{
	public class ComPorDni: EstrategiaDeComparacion
	{
		public bool sosIgual(Comparable a, Comparable b){
			return ((Alumno)a).getDni()==((Alumno)b).getDni();
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			return ((Alumno)a).getDni()<((Alumno)b).getDni();
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			return ((Alumno)a).getDni()>((Alumno)b).getDni();
		}
	}
}
