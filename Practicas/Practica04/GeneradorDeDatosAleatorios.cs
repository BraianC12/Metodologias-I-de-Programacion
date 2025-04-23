
using System;

namespace Practica04
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		static Random random=new Random();
		
		public int numeroAleatorio(int max){
			return random.Next(max);
		}
		
		public string stringAleatorio(int cantidad=5){
			const string alfabeto="abcdefghijklmnopqrstuvwxyz";
			char[] caracteres= new char[cantidad];
			
			for(int i=0; i<cantidad;i++){
				int indice= random.Next(alfabeto.Length);
				caracteres[i]= alfabeto[indice];
			}
			
			return new string(caracteres);
			
		}
	}
}
