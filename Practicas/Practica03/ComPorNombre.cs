
using System;

namespace Practica03
{
	public class ComPorNombre: EstrategiaDeComparacion
	{
		public bool sosIgual(Comparable a, Comparable b){
			return ((Alumno)a).getNombre().Length==((Alumno)b).getNombre().Length;
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			return ((Alumno)a).getNombre().Length<(((Alumno)b).getNombre().Length);
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			return ((Alumno)a).getNombre().Length>(((Alumno)b).getNombre().Length);
		}

	}
}
