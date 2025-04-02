using System;
using System.Collections.Generic;

namespace Practica02
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
		
		public List<Comparable> getElementos(){
			List<Comparable> elementos = new List<Comparable>();
		    
		    // Recorrer y agregar elementos de la pila
		    foreach (Comparable item in pila.getElementos())
		    {
		        elementos.Add(item);
		    }
		
		    // Recorrer y agregar elementos de la cola
		    foreach (Comparable item in cola.getElementos())
		    {
		        elementos.Add(item);
		    }
			//retorna la lista con los elementos combinados (pila y cola)
		    return elementos;			
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
			Comparable maxPila=pila.maximo();
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
		
		//ejercicio05
		public Iterador crearIterador(){
			return new IteradorColeccionMultiple(this);
		}
		
	}
}
