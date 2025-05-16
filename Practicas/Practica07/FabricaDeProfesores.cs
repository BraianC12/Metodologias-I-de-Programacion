using System;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores: FabricaDeComparables
	{
	
		public override Comparable crearAleatorio(){
			return new Profesor(responsables.stringAleatorio(), responsables.numeroAleatorio(10000000), responsables.stringAleatorio(), responsables.numeroAleatorio(100000));
		}
		
		public override Comparable crearPorTeclado(){
			return new Profesor(responsables.stringPorTeclado(), responsables.numeroPorTeclado(), responsables.stringPorTeclado(), responsables.numeroPorTeclado());
		}
		public override Comparable crearPorArchivo()
		{
			return new Profesor(responsables.stringDesdeArchivo(100), (int)responsables.numeroDesdeArchivo(1000), responsables.stringDesdeArchivo(1000), (int)responsables.numeroDesdeArchivo(1000));
		}
		
	}
}
