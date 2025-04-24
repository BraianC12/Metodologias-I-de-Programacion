using System;

namespace Practica05
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso: Alumno
	{
		//ejercicio 02 - practica 04
		private int pregunta;
		
		public AlumnoMuyEstudioso(int pregunta, string nombre, int dni, string apellido, int legajo, double promedio): base(nombre, dni, apellido, legajo, promedio){
			this.pregunta=pregunta;
		}
		
		public override int responderPregunta(int pregunta){
			return pregunta % 3;
		}
	}
}
