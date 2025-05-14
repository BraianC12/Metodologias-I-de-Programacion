using System;

namespace Juego
{
	/// <summary>
	/// Description of JuegoDeCarta.
	/// </summary>
	public abstract class JuegoDeCarta
	{
		//ejercicio 04 - practica 06
		protected Jugador jugador1;
		protected Jugador jugador2;
		protected Random random=new Random();
		
		public JuegoDeCarta(Jugador jugador1, Jugador jugador2){
			this.jugador1=jugador1;
			this.jugador2=jugador2;
		}
		
		//ejercicio 06 - practica 06
		public void Jugar(){
			int puntosParaGanar=3; //al mejor de tres partidas
			
			while (jugador1.getPuntos() < puntosParaGanar && jugador2.getPuntos() < puntosParaGanar){
				mezclar();
				repartir();
				while(!hayGanador()){
					descartar();
					tomarCarta();
				}
				Jugador ganadorDeLaPartida= ganador();
				ganadorDeLaPartida.sumarPunto();
				Console.WriteLine("Ganador: " + ganadorDeLaPartida);
				Console.WriteLine("Total de puntos: " + ganadorDeLaPartida.getPuntos());
			}
			
			if(jugador1.getPuntos()==puntosParaGanar){
				Console.WriteLine("EL GANADOR DE LA PARTIDA ES: " + jugador1);
			}
			else{Console.WriteLine("EL GANADOR DE LA PARTIDA ES: " + jugador2);}
			
		}
		
		private void mezclar(){
			Console.WriteLine("Mezclando las cartas");
			Console.WriteLine("Mezclando por segunda vez");
		}
		
		protected abstract void repartir();
		protected abstract bool hayGanador();
		protected abstract void descartar();
		protected abstract void tomarCarta();
		protected abstract Jugador ganador();
	}
}
