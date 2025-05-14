using System;

namespace Juego
{
	/// <summary>
	/// Description of Truco.
	/// </summary>
	public class Chinchon: JuegoDeCarta
	{
		//ejercicio 04 - practica 06
		private int ronda=0;
		
		public Chinchon(Jugador jugador1, Jugador jugador2): base(jugador1, jugador2){}
		
		
		protected override void repartir(){
			Console.WriteLine("Repartiendo las cartas del Chinchon");
		}
		
		protected override bool hayGanador(){
			ronda++;
			Console.WriteLine("Ronda " + ronda + " de Chinchon");
			return true;
		}
		
		protected override void descartar(){
			Console.WriteLine("Descartandose las cartas de Chinchon");
		}
		
		protected override void tomarCarta(){
			Console.WriteLine("Agarrando las cartas del mazo de Chinchon");
		}
		
		protected override Jugador ganador(){
			int valor= random.Next(2);
			if (valor==0){
				return jugador1;
			}
			
			else{return jugador2;}				
				
		}
			
	}
}
