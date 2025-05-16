using System;

namespace Practica07
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos: Manejador
	{
		public LectorDeDatos(Manejador sucesor): base(sucesor){}
		
		public override int numeroPorTeclado(){
			Console.Write("Ingresa un numero: ");
			int numero=int.Parse(Console.ReadLine());
			return numero;
		}
		
		public override string stringPorTeclado(){
			Console.Write("Ingrese una palabra: ");
			string palabra=Console.ReadLine();
			return palabra;
		}
		
		/*
		public override string stringAleatorio(int cantidad)
		{
			Console.WriteLine("Yo no se genenerar string aleatorios, pero para que me fijo si alguien de aca lo sabe");
			return sucesor.stringAleatorio(cantidad);
		}
		*/
	}
}
