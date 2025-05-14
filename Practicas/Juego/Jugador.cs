using System;

namespace Juego
{
	/// <summary>
	/// Description of Jugador.
	/// </summary>
	public class Jugador
	{
		//ejercicio 04 - practica 06
		private string nombre; 
		private string apellido;
		//ejercicio 06 - practica 06
		private int puntos;
		
		public Jugador(string nombre, string apellido)
		{
			this.nombre=nombre;
			this.apellido=apellido;
			this.puntos=0;
		}
		
		public int getPuntos(){
			return puntos;
		}
		
		public void sumarPunto(){
			puntos++;
		}
		
		public void reiniciarPuntos(){
			puntos=0;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public string getApellido(){
			return apellido;
		}
		
		public override string ToString(){
			return getNombre() + " " + getApellido();
		}
		
	}
}
