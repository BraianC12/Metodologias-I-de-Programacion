using System;
using System.Collections.Generic;
namespace Practica04
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor: Persona, Observado, Comparable
	{
		private int antiguedad;		
		private List<Observador> observadores;
		private bool hablando;
		
		
		public Profesor(string n, int d, string apellido, int a): base(n, d, apellido)
		{
			this.antiguedad=a;
			this.observadores=new List<Observador>();
		}
		
		public bool isHablando(){
			return hablando; 
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
		}
		
		public void hablarALaclase(){
			Console.WriteLine("Hablando de algun tema");
			hablando=true;
			notificar();
		
		}
		
		public void escribirAlPizarron(){
			Console.WriteLine("Escribiendo en el pizarrón");
			hablando=false;
			notificar();
		}
		
		public override string ToString(){
			return "Nombre + " + nombre + " Dni: " + dni + " antiguedad: " + antiguedad;
		}
		
		
		public void agregarObservador(Observador o){
			this.observadores.Add(o);
		}
		
		public void quitarObservador(Observador o){
			this.observadores.Remove(o);
		}
		
		public void notificar(){
			foreach(Observador observador in observadores){
				observador.actualizar(this);
			}
		}
		
		//implemento la interfaz comparable
		public bool sosIgual(Comparable a, Comparable b){
			return this.getAntiguedad()==((Profesor)b).getAntiguedad();
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			return this.getAntiguedad()<((Profesor)b).getAntiguedad();
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			return this.getAntiguedad()>((Profesor)b).getAntiguedad();
		}
		
	}
}
