using System;

namespace Practica05
{
	/// <summary>
	/// Description of FabricaDeAlumnosProxy.
	/// </summary>
	public class FabricaDeAlumnosProxy: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoProxy(generador.stringAleatorio(), 4); //alumno Proxy estudioso
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoProxy(lector.stringPorTeclado(), 4); //alumno Proxy estudioso
		}
	}
}
