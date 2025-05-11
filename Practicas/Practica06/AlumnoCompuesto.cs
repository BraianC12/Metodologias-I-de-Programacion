using System;
using System.Collections.Generic;

namespace Practica06
{
	/// <summary>
	/// Description of AlumnoCompuesto.
	/// </summary>
	public class AlumnoCompuesto: IAlumno
	{
		//ejercicio 01 - Practica 06
		private List<IAlumno> hijos;
		
		public AlumnoCompuesto()
		{
			this.hijos=new List<IAlumno>();
		}
		
		public void agregarHijo(IAlumno hijo){
			this.hijos.Add(hijo);
		}
		
		public string getNombre(){
			string nombres="";
			foreach(var hijo in hijos){
				nombres= nombres + hijo.getNombre() + "\n";
			}
			
			return nombres;
		}
		//Responder Pregunta
		
		public int responderPregunta(int pregunta){
			int suma=0;
			
			foreach(var hijo in hijos){
				suma+=hijo.responderPregunta(pregunta);
			}
			
			return suma/hijos.Count;
		}
		
		public void setCalificacion(int valor){
			foreach (var hijo in hijos){
				hijo.setCalificacion(valor);
			}
		}
		
		public string mostrarCalificaciones(){
			string calificaciones="";
			
			foreach(var hijo in hijos){
				calificaciones +=hijo.mostrarCalificaciones() + "\n";
			}
			return calificaciones;
		}
		
		public bool sosIgual(Comparable a){
			foreach (var hijo in hijos){
				if(hijo.sosIgual(a)){
					return true;
				}
			}
			return false;
		}
		
		
		public bool sosMenor(Comparable a){
			foreach (var hijo in hijos){
				if(!hijo.sosMenor(a)){
					return false;
				}
			}
			return true;
		}
		
		public bool sosMayor(Comparable a){
			foreach (var hijo in hijos){
				if(!hijo.sosMayor(a)){
					return false;
				}
			}
			return true;
		}
		
		//implementaciones restantes
		
		public int getLegajo(){
			if(hijos.Count == 0){
				return 0;
			}
			
			return hijos[0].getLegajo();
		}
		
		public int getDni(){
			if(hijos.Count == 0){
				return 0;
			}
			
			return hijos[0].getDni();
		}
		
		public double getPromedio(){
			double suma=0;
			
			foreach(var hijo in hijos){
				suma+=hijo.getCalificacion();
			}
			
			return suma/hijos.Count;
		}
		
		public int getCalificacion(){
			int suma=0;
			
			foreach(var hijo in hijos){
				suma+=hijo.getCalificacion();
			}
			
			return suma/hijos.Count; //promediod de calificaciones
		}
        
		public void setEstrategia(EstrategiaDeComparacion e) {
			foreach(var hijo in hijos){
				hijo.setEstrategia(e);
			}
		}
        
		public void setNombre(string nombre) {
			foreach(var hijo in hijos){
				hijo.setNombre(nombre);
			}
		}
		
		
	}
}
