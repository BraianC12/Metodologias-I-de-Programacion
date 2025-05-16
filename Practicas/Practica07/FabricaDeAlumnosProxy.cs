using System;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeAlumnosProxy.
	/// </summary>
	public class FabricaDeAlumnosProxy: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoProxy(responsables.stringAleatorio(), 4); //alumno Proxy estudioso
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoProxy(responsables.stringPorTeclado(), 4); //alumno Proxy estudioso
		}
		
		public override Comparable crearPorArchivo(){
			return new AlumnoProxy(responsables.stringDesdeArchivo(100), 4);
		}
	}
}
