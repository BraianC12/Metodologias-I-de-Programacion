using System;

namespace Practica03
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDeComparables
	{
		//ejercicio 05
		
		public override Comparable crearAleatorio(){
			return new Alumno(generador.stringAleatorio(), generador.numeroAleatorio(10000000), generador.numeroAleatorio(100000), (double)generador.numeroAleatorio(100),new ComPorDni());
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), (double)lector.numeroPorTeclado(),new ComPorDni());
		}
		
	}
}
