using System;

namespace Practica06
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio: OrdenEnAula1
	{
		//ejercicio 05 - practica 05
		private Aula aula;
		public OrdenInicio(Aula aula)
		{
			this.aula=aula;
		}
		
		//implementacion de la interfaz OrdenEnAula1
		public void ejecutar(){
			aula.comenzar();
		}
		
		
	}
}
