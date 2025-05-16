using System;
using System.Collections.Generic;

namespace Practica07
{

	public class Numero: Comparable
	{
		
		private int valor;
		
		public Numero(int valor){
			this.valor=valor;
		}
		
		public int Valor(){
			return this.valor;
		}
		
		//implementacion de interfaces
		public bool sosIgual(Comparable c){
			return valor== ((Numero)c).valor;
		}
		
		public bool sosMenor(Comparable c){
			return valor<((Numero)c).valor;
		}
		
		public bool sosMayor(Comparable c){
			return valor>((Numero)c).valor;
		}
		
		//investigue para que muestre los valores en pantalla
        public override string ToString()
        {
            return valor.ToString(); // Devuelve el valor del número como cadena
        }

		
	}
}
