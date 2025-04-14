using System;

namespace Practica03
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores: FabricaDeComparables
	{
		//ejercicio 09
		public override Comparable crearAleatorio(){
			return new Profesor(generador.stringAleatorio(), generador.numeroAleatorio(10000000), generador.numeroAleatorio(100000), new ComPorAntiguedad());
		}
		
		public override Comparable crearPorTeclado(){
			return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), new ComPorAntiguedad());
		}
	}
}
