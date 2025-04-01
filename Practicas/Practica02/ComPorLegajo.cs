using System;

namespace Practica02
{

	public class ComPorLegajo: EstrategiaDeComparacion
	{
		//Ejercicio 01
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getLegajo()==a2.getLegajo();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getLegajo()<a2.getLegajo();
		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getLegajo()>a2.getLegajo();
		}
	}
}
