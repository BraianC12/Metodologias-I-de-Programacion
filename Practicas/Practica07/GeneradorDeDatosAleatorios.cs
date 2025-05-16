
using System;

namespace Practica07
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios: Manejador
	{
		//ejercicio 04 - practica 07
		private static GeneradorDeDatosAleatorios unicaInstancia = null;
		
		//private GeneradorDeDatosAleatorios(Manejador sucesor): base(sucesor){}
		public GeneradorDeDatosAleatorios(Manejador sucesor): base(sucesor){}
		static Random random=new Random();
		
		public override int numeroAleatorio(int max){
			return random.Next(max);
		}
		
		public override string stringAleatorio(int cantidad=5){
			const string alfabeto="abcdefghijklmnopqrstuvwxyz";
			char[] caracteres= new char[cantidad];
			
			for(int i=0; i<cantidad;i++){
				int indice= random.Next(alfabeto.Length);
				caracteres[i]= alfabeto[indice];
			}
			
			return new string(caracteres);
		}
		
		//ejercicio 04 - practica 07
		
		//implementacion de Singleton
		public static GeneradorDeDatosAleatorios getInstance(Manejador m){
			if(unicaInstancia == null){
				unicaInstancia= new GeneradorDeDatosAleatorios(m);
			}
			return unicaInstancia;
		}
		
	}
}
