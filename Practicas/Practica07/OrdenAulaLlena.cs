using System;

namespace Practica07
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena: OrdenEnAula1
	{
		//ejercicio 05 - practica 05
		private Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula=aula;
		}
		
		//implementar interfaz
		public void ejecutar(){
			aula.claseLista();
		}
	}
}
