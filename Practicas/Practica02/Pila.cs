using System;
using System.Collections.Generic;

namespace Practica02
{
	public class Pila: Coleccionable
	{
		//ejercicio 04
		List<Comparable>Elementos;
	
		public Pila()
		{
			this.Elementos=new List<Comparable>();
		}
		
		//ejercicio 05
		public List<Comparable> getElementos(){
			return Elementos;
		}
		
		//implementacion de la interfaz Colecionable
		public int cuantos(){
			return Elementos.Count;
		}
		
		public void agregar(Comparable c){
			Elementos.Add(c);
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
		
		//Ejercicio 05
		//implemento la interfaz iterable
		public Iterador crearIterador(){
			return new IteradorPila(this); //primero elemento
		}
		
	}
}
