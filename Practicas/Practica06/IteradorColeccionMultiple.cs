using System;

namespace Practica06
{
	public class IteradorColeccionMultiple: Iterador
	{
		private int indice;
		private ColeccionMultiple cm;
		
		public IteradorColeccionMultiple(ColeccionMultiple cm)
		{
			this.cm=cm;
			this.primero();
		}
		
		public void primero(){
			this.indice=0;
		}
		
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice>=cm.cuantos();
		}
		
		public Comparable actual(){
			return cm.getElementos()[indice];
		}
	}
}
