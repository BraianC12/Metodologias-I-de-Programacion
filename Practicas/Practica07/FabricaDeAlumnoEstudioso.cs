using System;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeAlumnoEstudioso.
	/// </summary>
	public class FabricaDeAlumnoEstudioso: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(responsables.numeroAleatorio(1000), responsables.stringAleatorio(), responsables.numeroAleatorio(1000), responsables.stringAleatorio(), responsables.numeroAleatorio(10000000), (double)responsables.numeroAleatorio(100));
		}
		
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(responsables.numeroPorTeclado(), responsables.stringPorTeclado(), responsables.numeroPorTeclado(), responsables.stringPorTeclado(), responsables.numeroPorTeclado(), (double)responsables.numeroPorTeclado());
		}
		
		public override Comparable crearPorArchivo(){
			return new AlumnoMuyEstudioso((int)responsables.numeroDesdeArchivo(100), responsables.stringDesdeArchivo(20), (int)responsables.numeroDesdeArchivo(1000), responsables.stringDesdeArchivo(20), (int)responsables.numeroDesdeArchivo(10000), (double)responsables.numeroDesdeArchivo(10000));
		}
	}
}
