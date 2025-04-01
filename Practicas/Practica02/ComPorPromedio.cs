using System;

namespace Practica02
{
	public class ComPorPromedio: EstrategiaDeComparacion
	{
		//Ejercicio 01
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getPromedio()==a2.getPromedio();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getPromedio()<a2.getPromedio();
		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getPromedio()>a2.getPromedio();
		}
	}
}
