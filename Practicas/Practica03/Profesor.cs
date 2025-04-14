using System;

namespace Practica03
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor: Persona
	{
		//ejercicio 08
		private int antiguedad;
		private EstrategiaDeComparacion estrategia;
		
		public Profesor(string n, int d, int a, EstrategiaDeComparacion estrategia): base(n, d)
		{
			this.antiguedad=a;
			this.estrategia=estrategia;
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
		}
		
		public void hablarALaclase(){
			Console.WriteLine("Hablando de algun tema");
		}
		
		public void escribirAlPizarron(){
			Console.WriteLine("Escribiendo en el pizarrón");
		}
		
		//implementacion de interfaz
		//ejercicio09
		public override bool sosMenor(Comparable c){
			return this.estrategia.sosMenor(this, (Profesor)c); //si el objeto actual es menor que el objeto c
		}
		public override bool sosMayor(Comparable c){
			return this.estrategia.sosMayor(this, (Profesor)c);
		}
		public override bool sosIgual(Comparable c){
			return this.estrategia.sosIgual(this, (Profesor)c);
		}
		
		public void setEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.estrategia=nvaEstrategia;
		}
		
		public override string ToString(){
			return "Nombre + " + nombre + " Dni: " + dni + " antiguedad: " + antiguedad;
		}
		
	}
}
