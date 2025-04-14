using System;
using System.Collections.Generic;

namespace Practica03
{
	//Ejercicio 12
	public class Alumno: Persona, Observador
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
		
		
		public override string ToString(){
			return "Nombre: " + nombre + " Dni: " + dni;
		}
		
		//ejercicio 11
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		
		public void distraerse(){
			Random random= new Random();
			string[] frases=new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
			Console.WriteLine(frases[random.Next(0,2)]);
		}
		
		//implemento la interfaz Observador
		public void actualizar(Observado o){
			if(((Profesor)o).isHablando()){
				this.prestarAtencion();
			}
			else{this.distraerse();}
		}
		
	}
}
