using System;
using System.Collections.Generic;


namespace Practica04
{
	
	public class Alumno: Persona, Observador, IAlumno, Comparable
	{
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		private int calificacion;
		
		public Alumno(string n, int d, string apellido, int l, double p): base(n, d, apellido)
		{
			this.legajo=l;
			this.promedio=p;
			this.estrategia=new ComPorLegajo();
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public double getPromedio(){
			return promedio;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public int getDni(){
			return dni;
		}
		
		public int getCalificacion(){
			return calificacion;
		}
		
		public void setCalificacion(int valor){
			calificacion=valor;
		}
		
	
		public override bool sosMenor(Comparable c){
			return this.estrategia.sosMenor(this, (IAlumno)c); //si el objeto actual es menor que el objeto c
		}
		public override bool sosMayor(Comparable c){
			return this.estrategia.sosMayor(this, (IAlumno)c);
		}
		public override bool sosIgual(Comparable c){
			return this.estrategia.sosIgual(this, (IAlumno)c);
		}
		
		public void setEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.estrategia=nvaEstrategia;
		}
		
		
		public override string ToString(){
			return "Nombre: " + nombre + " Dni: " + dni;
		}
		
		
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
		
		//ejercicio 01 - practica 04
		public virtual int responderPregunta(int pregunta){
			Random random=new Random();
			return random.Next(1,4);
		}
		
		public string mostrarCalificaciones(){
			return nombre + " " + apellido + " 		" + calificacion;
		}
		
		
		
	}
}
