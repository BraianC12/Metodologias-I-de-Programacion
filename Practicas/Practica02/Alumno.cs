using System;
using System.Collections.Generic;

namespace Practica02
{
	//Ejercicio 12
	public class Alumno: Persona
	{
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		
		public Alumno(string n, int d, int l, double p, EstrategiaDeComparacion estrategia): base(n, d)
		{
			this.legajo=l;
			this.promedio=p;
			this.estrategia=estrategia;
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public double getPromedio(){
			return promedio;
		}
		
		
		
		
		//Ejercicio 02
		//implementacion de interfaces
		public override bool sosMenor(Comparable c){
			return this.estrategia.sosMenor(this, (Alumno)c); //si el objeto actual es menor que el objeto c
		}
		public override bool sosMayor(Comparable c){
			return this.estrategia.sosMayor(this, (Alumno)c);
		}
		public override bool sosIgual(Comparable c){
			return this.estrategia.sosIgual(this, (Alumno)c);
		}
		
		public void setEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.estrategia=nvaEstrategia;
		}
	
		
	}
}
