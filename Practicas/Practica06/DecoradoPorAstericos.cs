using System;

namespace Practica06
{
	/// <summary>
	/// Description of DecoradoPorAstericos.
	/// </summary>
	public class DecoradoPorAstericos: AlumnoDecorator
	{
		//ejercicio 06 -practica 04
		public DecoradoPorAstericos(IAlumno a): base(a){}
		
		public override string mostrarCalificaciones()
		{
			string astericos= "***********************************************";
			string res=base.mostrarCalificaciones();
			return astericos + "\n" + "* " + res + "*\n" + astericos; 
		}
		
	}
}
