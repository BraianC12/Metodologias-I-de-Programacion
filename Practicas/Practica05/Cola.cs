using System;
using System.Collections.Generic;


namespace Practica05
{
	public class Cola: Coleccionable, Ordenable
	{
		//ejercicio 04
		
		Queue<Comparable> Elementos;
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		private OrdenEnAula2 ordenLlegaAlumno;
		
		public Cola()
		{
			this.Elementos=new Queue<Comparable>();
		}
		
		public List<Comparable> getElementos(){
			return new List<Comparable>(Elementos);
		}
		
		
		//implementacion de interfaces
		public int cuantos(){
			return Elementos.Count;
		}
		
		public Comparable minimo(){
			if(Elementos.Count==0){
				return null;
			}
			
			Comparable minimo=Elementos.Peek(); //accede al primer elemento de la cola
			foreach(Comparable c in Elementos){
				if(c.sosMenor(minimo)){
					minimo = c;
				}
			}
			return minimo;
		}
		
		
		public Comparable maximo(){
			if(Elementos.Count==0){
				return null;
			}
			
			Comparable maximo=Elementos.Peek(); //accede al primer elemento de la cola
			foreach(Comparable c in Elementos){
				if(c.sosMayor(maximo)){
					maximo = c;
				}
			}
			return maximo;
		}
		
		
		public bool contiene(Comparable c){
			foreach(Comparable e in Elementos){
				if(e.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
			//ejercicio 09 - practica 05
		public void agregar(Comparable c){
				Elementos.Enqueue(c);
			
			if(Elementos.Count == 1 && ordenInicio !=null){
				ordenInicio.ejecutar();
			}
			
			if(ordenLlegaAlumno != null){
				ordenLlegaAlumno.ejecutar(c);
			}
			
			if(Elementos.Count == 40 && ordenAulaLlena != null){
				ordenAulaLlena.ejecutar();
			
			}
		}
		
		//ejercicio05
		//implemento la interfaz Iterable
		public Iterador crearIterador(){
			return new IteradorCola(this);
		}
		
		//ejercicio 09 - practica 05
		//implemenatr la interfaz Ordenable
		public void setOrdenInicio(OrdenEnAula1 o){
			ordenInicio= o;
		}
		
		public void setOrdenLlegaAlumno(OrdenEnAula2 o){
			ordenLlegaAlumno= o;
		}
		
		public void setOrdenAulaLlena(OrdenEnAula1 o){
			ordenAulaLlena= o;
		}
		
		
	}
}
