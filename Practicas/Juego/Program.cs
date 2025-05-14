using System;

namespace Juego
{
	class Program
	{
		public static void Main(string[] args)
		{
			//ejercicio 05 - practica 06
			int opcion;
			Jugador jugador1=new Jugador("Braian", "Carranza");
			Jugador jugador2=new Jugador("Daniel", "Agostini");
			
			do{
				Console.WriteLine("\nJugador: " + jugador1 + " Puntos: " + jugador1.getPuntos());
				Console.WriteLine("\nJugador: " + jugador2 + " Puntos: " + jugador2.getPuntos());
				
				Console.WriteLine("\n1 - Truco");
				Console.WriteLine("2 - Chinchon");
				Console.WriteLine("3 - Salir");
				
				Console.Write("Eliga una opcion: ");
				opcion=int.Parse(Console.ReadLine());
				
				switch(opcion){
						case 1: 
						jugador1.reiniciarPuntos();
						jugador2.reiniciarPuntos();
						JuegoDeCarta juego1=new Truco(jugador1, jugador2);
						juego1.Jugar();
						break;
						
						case 2:
						jugador1.reiniciarPuntos();
						jugador2.reiniciarPuntos();
						JuegoDeCarta juego2=new Chinchon(jugador1, jugador2);
						juego2.Jugar();
						break;
						
						case 3: Console.WriteLine("Esta saliendo del juego"); break;
						default: Console.WriteLine("Opcion invalida");break;
				}
			}while(opcion !=3);
			
			Console.ReadKey(true);
		}
	}
}