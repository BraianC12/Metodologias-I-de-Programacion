using System;

namespace Practica05
{

	public class ComPorLegajo: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a, IAlumno b){
			return a.getLegajo()==b.getLegajo();
		}
		
		public bool sosMenor(IAlumno a, IAlumno b){
			return a.getLegajo()<b.getLegajo();
		}
		
		public bool sosMayor(IAlumno a, IAlumno b){
			return a.getLegajo()>b.getLegajo();
		}
	}
}
