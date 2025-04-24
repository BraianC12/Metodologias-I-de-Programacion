using System;

namespace Practica05
{
	/// <summary>
	/// Description of DecoradoPorEstado.
	/// </summary>
	public class DecoradoPorEstado: AlumnoDecorator
	{
		//ejercicio 06 -practica 04
		public DecoradoPorEstado(IAlumno a): base(a){}
		
		public override string mostrarCalificaciones()
		{
			string estado;
			if(getCalificacion()>=7){
				estado="PROMOCION";
			}
			else if(getCalificacion()<7 && getCalificacion()>=4){
				estado="APROBADO";
			}
			else{
				estado="DESAPROBADO";
			}
			string res=base.mostrarCalificaciones();
			res=res+" (" + estado + ")";
			return res;

		}
		
	}
}
