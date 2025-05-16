using System;

namespace Practica07
{
	/// <summary>
	/// Description of DecoradoPorLetras.
	/// </summary>
	public class DecoradoPorLetras: AlumnoDecorator
	{
		//ejercicio 06 -practica 04
		public DecoradoPorLetras(IAlumno a): base(a){}
		
		public override string mostrarCalificaciones(){
			string[] letras= {"cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez"};
			return base.mostrarCalificaciones() + "(" + letras[base.getCalificacion()] + ")";
		}
	}
}
