using System;
using System.Collections.Generic;

namespace Practica04
{

	public class ColeccionMultiple: Coleccionable
	{
		private Pila pila;
		private Cola cola;
		
		public ColeccionMultiple(Pila pila, Cola cola)
		{
			this.pila= pila;
			this.cola= cola;
		}
		
		public List<Comparable> getElementos(){
			List<Comparable> elementos = new List<Comparable>();
		    
		    foreach (Comparable item in pila.getElementos())
		    {
		        elementos.Add(item);
		    }
		
		    foreach (Comparable item in cola.getElementos())
		    {
		        elementos.Add(item);
		    }
			
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
			return pila.contiene(c) || cola.contiene(c); 
		}
		
		public Iterador crearIterador(){
			return new IteradorColeccionMultiple(this);
		}
		
	}
}
