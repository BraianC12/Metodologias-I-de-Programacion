using System;
using System.Collections.Generic;

namespace Practica05
{
	public class Pila: Coleccionable, Ordenable
	{
		List<Comparable>Elementos;
		//ejercicio 09 - practica 05
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		private OrdenEnAula2 ordenLlegaAlumno;
		
		public Pila()
		{
			this.Elementos=new List<Comparable>();
		}
		
		public List<Comparable> getElementos(){
			return Elementos;
		}
		
		//implementacion de la interfaz Colecionable
		public int cuantos(){
			return Elementos.Count;
		}
		
		//ejercicio 09 - practica 05
		public void agregar(Comparable c){
			Elementos.Add(c);
			
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
		
		public Comparable minimo(){
			Comparable minimoActual=Elementos[0];
			for(int i=1;i<cuantos(); i++){
				if(Elementos[i].sosMenor(minimoActual)){
					minimoActual=Elementos[i];
				}
			}
			return minimoActual;
		}
		
		public Comparable maximo(){
			Comparable maximoActual=Elementos[0];
			for(int i=1;i<cuantos(); i++){
				if(Elementos[i].sosMayor(maximoActual)){
					maximoActual=Elementos[i];
				}
			}
			return maximoActual;
		}
		
		
		public bool contiene(Comparable c){
			foreach(Comparable e in Elementos){
				if(e.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
		
		//implemento la interfaz iterable
		public Iterador crearIterador(){
			return new IteradorPila(this); //primero elemento
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
