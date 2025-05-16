using System;
using System.Collections.Generic;

namespace Practica07
{

	public abstract class Persona: Comparable
	{
		protected string nombre;
		protected int dni;
		protected string apellido;
				
		
		public Persona(string n, int d, string apellido)
		{
			this.nombre=n;
			this.dni=d;
			this.apellido=apellido;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public void setNombre(string nom){
			this.nombre=nom;
		}
		
		public int getDni(){
			return dni;
		}
		
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
