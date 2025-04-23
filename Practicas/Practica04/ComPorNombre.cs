
using System;

namespace Practica04
{
	public class ComPorNombre: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a, IAlumno b){
			return a.getNombre().Length==b.getNombre().Length;
		}
		
		public bool sosMenor(IAlumno a, IAlumno b){
			return a.getNombre().Length<b.getNombre().Length;
		}
		
		public bool sosMayor(IAlumno a, IAlumno b){
			return a.getNombre().Length>b.getNombre().Length;
		}

	}
}
