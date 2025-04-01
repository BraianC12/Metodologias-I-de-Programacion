using System;
using System.Collections.Generic;
namespace Practica02
{
	public class Cola: Coleccionable
	{
		//ejercicio 04
		
		Queue<Comparable> Elementos;
		
		public Cola()
		{
			this.Elementos=new Queue<Comparable>();
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
		
		public void agregar(Comparable c){
			Elementos.Enqueue(c); //agrega el elemento al final de la cola
		}
		
		public bool contiene(Comparable c){
			foreach(Comparable e in Elementos){
				if(e.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
		
		
	}
}
