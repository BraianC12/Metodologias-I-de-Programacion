using System;
using System.Collections.Generic;

namespace Practica03
{
	public class Conjunto: Coleccionable
	{
		//ejercicio 03
		private List<Comparable> elementos;
		
		
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
			}
		}
		
		//ejercicio 04
		public int cuantos(){
			return elementos.Count;
		}
		
		//la implementacion de la interfaz "agregar" ya fue realizada en la actividad anterior
		
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
		
		//ejercicio 05
		//implemento la interfaz Iterable
		public Iterador crearIterador(){
			return new IteradorConjunto(this);
		}
		
	}
}
