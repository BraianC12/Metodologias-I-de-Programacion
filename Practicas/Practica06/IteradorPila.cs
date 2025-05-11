using System;

namespace Practica06
{
	public class IteradorPila: Iterador
	{
		private int indice;
		private Pila p;
		
		public IteradorPila(Pila p)
		{
			this.p=p;
			this.primero();
		}
		
		public void primero(){
			this.indice=0;
		}
		
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice >=p.cuantos();
		}
		
		public Comparable actual(){
			return p.getElementos()[indice];
		}
	}
}
