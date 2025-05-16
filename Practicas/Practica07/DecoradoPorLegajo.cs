using System;

namespace Practica07
{
	/// <summary>
	/// Description of DecoradoPorLegajo.
	/// </summary>
	public class DecoradoPorLegajo: AlumnoDecorator
	{
		//ejercicio 06 -practica 04
		public DecoradoPorLegajo(IAlumno a): base(a){
			
		}
		
		public override string mostrarCalificaciones(){
			string res=base.mostrarCalificaciones();
			res=res.Insert(res.IndexOf('\t'), "(" + base.getLegajo() + ")");
			return res;
		}
	}
}
