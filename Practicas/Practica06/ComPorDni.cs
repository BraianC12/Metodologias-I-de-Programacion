using System;

namespace Practica06
{
	public class ComPorDni: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a, IAlumno b){
			return a.getDni()==b.getDni();
		}
		
		public bool sosMenor(IAlumno a, IAlumno b){
			return a.getDni()<b.getDni();
		}
		
		public bool sosMayor(IAlumno a, IAlumno b){
			return a.getDni()>b.getDni();
		}
	}
}
