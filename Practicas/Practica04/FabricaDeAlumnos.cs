using System;

namespace Practica04
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDeComparables
	{	
		public override Comparable crearAleatorio(){
			return new Alumno(generador.stringAleatorio(), generador.numeroAleatorio(10000000),generador.stringAleatorio() ,generador.numeroAleatorio(100000), (double)generador.numeroAleatorio(100));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.stringPorTeclado(), lector.numeroPorTeclado(), (double)lector.numeroPorTeclado());
		}
		
	}
}
