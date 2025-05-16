using System;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDeComparables
	{	
		public override Comparable crearAleatorio(){
			return new Alumno(responsables.stringAleatorio(), responsables.numeroAleatorio(10000000),responsables.stringAleatorio() ,responsables.numeroAleatorio(100000), (double)responsables.numeroAleatorio(100));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(responsables.stringPorTeclado(), responsables.numeroPorTeclado(), responsables.stringPorTeclado(), responsables.numeroPorTeclado(), (double)responsables.numeroPorTeclado());
		}
		
		public override Comparable crearPorArchivo(){
			return new Alumno(responsables.stringDesdeArchivo(1000), (int)responsables.numeroDesdeArchivo(20), responsables.stringDesdeArchivo(1000), (int)responsables.numeroDesdeArchivo(20), (double)responsables.numeroDesdeArchivo(100));
		}
		
	}
}
