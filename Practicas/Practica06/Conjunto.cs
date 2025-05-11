using System;
using System.Collections.Generic;

namespace Practica06
{
	public class Conjunto: Coleccionable, Ordenable
	{
		private List<Comparable> elementos;
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		private OrdenEnAula2 ordenLlegaAlumno;
		
		
		public Conjunto()
		{
			elementos=new List<Comparable>();
		}
		
		public List<Comparable> getElementos(){
			return elementos;
		}
		
		public bool pertenece(Comparable c){
			return elementos.Contains(c); //retorna true si la cadena esta en ese elemento
		}
		
		public void agregar(Comparable c){
			if(pertenece(c) == false){ //si retorna falso, agrega el elemento
				elementos.Add(c);
				if(elementos.Count == 1 && ordenInicio !=null){
					ordenInicio.ejecutar();
				}
					
				if(ordenLlegaAlumno != null){
					ordenLlegaAlumno.ejecutar(c);
				}
					
				if(elementos.Count == 40 && ordenAulaLlena != null){
					ordenAulaLlena.ejecutar();
				}
			}
		}
		
		public int cuantos(){
			return elementos.Count;
		}
		
		public Comparable minimo(){
			Comparable minimoActual=elementos[0];
			for(int i=1;i<cuantos(); i++){
				if(elementos[i].sosMenor(minimoActual)){
					minimoActual=elementos[i];
				}
			}
			return minimoActual;
		}
		public Comparable maximo(){
			Comparable maximoActual=elementos[0];
			for(int i=1;i<cuantos(); i++){
				if(elementos[i].sosMenor(maximoActual)){
					maximoActual=elementos[i];
				}
			}
			return maximoActual;
		}
		
		public bool contiene(Comparable c){
			foreach(Comparable e in elementos){
				if(e.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
		
		//implemento la interfaz Iterable
		public Iterador crearIterador(){
			return new IteradorConjunto(this);
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
