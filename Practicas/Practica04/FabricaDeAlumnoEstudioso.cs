using System;

namespace Practica04
{
	/// <summary>
	/// Description of FabricaDeAlumnoEstudioso.
	/// </summary>
	public class FabricaDeAlumnoEstudioso: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(generador.numeroAleatorio(1000), generador.stringAleatorio(), generador.numeroAleatorio(1000), generador.stringAleatorio(), generador.numeroAleatorio(10000000), (double)generador.numeroAleatorio(100));
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(lector.numeroPorTeclado(), lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.stringPorTeclado(), lector.numeroPorTeclado(), (double)lector.numeroPorTeclado());
		}
	}
}
