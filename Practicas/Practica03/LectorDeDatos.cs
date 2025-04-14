using System;

namespace Practica03
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		//ejercicio 03
		public int numeroPorTeclado(){
			Console.Write("Ingresa un numero: ");
			int numero=int.Parse(Console.ReadLine());
			return numero;
		}
		
		public string stringPorTeclado(){
			Console.Write("Ingrese una palabra: ");
			string palabra=Console.ReadLine();
			return palabra;
		}
	}
}
