using System;

namespace Practica03
{
	public class IteradorConjunto: Iterador
	{
		private int indice;
		private Conjunto c;
		
		public IteradorConjunto(Conjunto c)
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
			return this.indice>=c.cuantos();
		}
		
		public Comparable actual(){
			return c.getElementos()[indice];
		}
	}

}
