using System;

namespace Practica03
{
	/// <summary>
	/// Description of ComPorAntiguedad.
	/// </summary>
	public class ComPorAntiguedad: EstrategiaDeComparacion
	{
		//ejercicio09
		public bool sosIgual(Comparable a, Comparable b){
			return ((Profesor)a).getAntiguedad()==((Profesor)b).getAntiguedad();
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			return ((Profesor)a).getAntiguedad()<((Profesor)b).getAntiguedad();
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			return ((Profesor)a).getAntiguedad()>((Profesor)b).getAntiguedad();
		}
	}
}
