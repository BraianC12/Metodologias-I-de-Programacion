using System;
using System.Collections.Generic;
namespace Ejercicios
{

	public class ColeccionMultiple: Coleccionable
	{
		//ejercicio 08
		private Pila pila;
		private Cola cola;
		
		public ColeccionMultiple(Pila pila, Cola cola)
		{
			this.pila= pila;
			this.cola= cola;
		}
		
		public int cuantos(){
			return pila.cuantos() + cola.cuantos();
		}
		
		public Comparable minimo(){
			Comparable miniPila=pila.minimo();
			Comparable miniCola=cola.minimo();
			
			if(miniPila.sosMenor(miniCola)){
				return miniPila;
			}
			else{return miniCola;}
		}
		
		public Comparable maximo(){
			Comparable maxPila=pila.minimo();
			Comparable maxCola=cola.maximo();
			
			if(maxPila.sosMayor(maxCola)){
				return maxPila;
			}
			else{return maxCola;}
		}
		
		public void agregar(Comparable c){
			pila.agregar(c);
		}
		
		
		public void agregarCola(Comparable c){
			cola.agregar(c);
		}
		
		public bool contiene(Comparable c){
			return pila.contiene(c) || cola.contiene(c); //verifica si cualquiera de los dos contiene el elemento
		}
		
	}
}
