using System;
using System.Collections.Generic;

namespace Practica06
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros: FabricaDeComparables
	{
		//Ejercicio 05
		public override Comparable crearAleatorio(){
			return new Numero(generador.numeroAleatorio(10000000));
		}
		
		public override Comparable crearPorTeclado(){
			return new Numero(lector.numeroPorTeclado());
		}
		
	}
}
