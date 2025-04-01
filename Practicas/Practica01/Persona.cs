using System;
using System.Collections.Generic;
namespace Practica01
{

	public abstract class Persona: Comparable
	{
		//Ejercicio 11
		protected string nombre;
		protected int dni;
				
		
		public Persona(string n, int d)
		{
			this.nombre=n;
			this.dni=d;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public int getDni(){
			return dni;
		}
		
		//Ejercicio11
		
		public virtual bool sosIgual(Comparable c){
			return dni==((Persona)c).dni;
		}
		
		
		public virtual bool sosMenor(Comparable c){
			return dni<((Persona)c).dni;
		}
	
		public virtual bool sosMayor(Comparable c){
			return dni>((Persona)c).dni;
		}
		
		
		//busque porque no me mostraba los datos en pantalla
        public override string ToString()
        {
            return dni.ToString(); // Devuelve el valor del número como cadena
        }
	}
}
