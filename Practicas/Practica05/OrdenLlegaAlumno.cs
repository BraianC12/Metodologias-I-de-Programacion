using System;

namespace Practica05
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno: OrdenEnAula2
	{
		//ejercicio 07 - practica 05
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula=aula;
		}
		
		//implementar la interfaz OrdenEnAula2
		public void ejecutar(Comparable c){
			aula.nuevoAlumno((IAlumno)c);
		}
		
	}
}
