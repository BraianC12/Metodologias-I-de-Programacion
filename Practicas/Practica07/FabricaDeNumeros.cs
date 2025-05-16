using System;
using System.Collections.Generic;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros: FabricaDeComparables
	{
		//Ejercicio 05
		public override Comparable crearAleatorio(){
			return new Numero(responsables.numeroAleatorio(10000000));
		}
		
		public override Comparable crearPorTeclado(){
			return new Numero(responsables.numeroPorTeclado());
		}
		
		public override Comparable crearPorArchivo()
		{
			return new Numero((int)responsables.numeroDesdeArchivo(100));
		}
		
	}
}
