using System;
using System.Collections.Generic;

namespace Practica01
{
	//Ejercicio 12
	public class Alumno: Persona
	{
		private int legajo;
		private int promedio;
		
		
		public Alumno(string n, int d, int l, int p): base(n, d)
		{
			this.legajo=l;
			this.promedio=p;
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public int getPromedio(){
			return promedio;
		}
		//Ejercicio 15
		//implementacion de interfaces
		public override bool sosMenor(Comparable c){
			Alumno otro=(Alumno)c;
			return legajo<otro.legajo;
		}
		public override bool sosMayor(Comparable c){
			Alumno otro=(Alumno)c;
			return legajo>otro.legajo;
		}
		public override bool sosIgual(Comparable c){
			Alumno otro=(Alumno)c;
			return legajo==otro.legajo;
		}
	
		
	}
}
