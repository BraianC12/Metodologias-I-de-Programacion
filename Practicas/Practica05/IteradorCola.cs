using System;

namespace Practica05
{
	public class IteradorCola: Iterador
	{
		private int indice;
		private Cola c;
		
		public IteradorCola(Cola c)
		{
			this.c=c;
			this.primero();
		}
		
		public void primero(){
			this.indice=0;
		}
		
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice >=c.cuantos();
		}
		
		public Comparable actual(){
			int i=0;
			foreach(Comparable elemento in c.getElementos()){ 
				if(i == indice){ //cuando lleguemos al indice deseado, se devuelve el elemento
					return elemento;
				}
				i++;
			}
			return null;
		}
	}
}
