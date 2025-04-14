using System;

namespace Practica03
{

	public class ComPorLegajo: EstrategiaDeComparacion
	{
		public bool sosIgual(Comparable a, Comparable b){
			return ((Alumno)a).getLegajo()==((Alumno)b).getLegajo();
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			return ((Alumno)a).getLegajo()<((Alumno)b).getLegajo();
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			return ((Alumno)a).getLegajo()>((Alumno)b).getLegajo();
		}
	}
}
