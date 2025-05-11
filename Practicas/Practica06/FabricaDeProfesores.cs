using System;

namespace Practica06
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores: FabricaDeComparables
	{
	
		public override Comparable crearAleatorio(){
			return new Profesor(generador.stringAleatorio(), generador.numeroAleatorio(10000000), generador.stringAleatorio(), generador.numeroAleatorio(100000));
		}
		
		public override Comparable crearPorTeclado(){
			return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.stringPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
