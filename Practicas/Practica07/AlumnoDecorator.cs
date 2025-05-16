using System;

namespace Practica07
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator: IAlumno
	{
		//ejercicio 06 - practica 04
		IAlumno adicional;
		
		public AlumnoDecorator(IAlumno a)
		{
			this.adicional=a;
		}
		
		//implemento la interfaz IAlumno
		public int getCalificacion(){
			return adicional.getCalificacion();
		}
		public int getLegajo(){
			return adicional.getLegajo();
		}
		
		public string getNombre(){
			return adicional.getNombre();
		}
		
		public double getPromedio(){
			return adicional.getPromedio();
		}
		
		public int getDni(){
			return adicional.getDni();
		}
		
		public bool sosIgual(Comparable c){
			return adicional.sosIgual(c);
		}
		
		public bool sosMayor(Comparable c){
			return adicional.sosMayor(c);
		}
		
		public bool sosMenor(Comparable c){
			return adicional.sosMenor(c);
		}
		
		public virtual string mostrarCalificaciones(){
			return adicional.mostrarCalificaciones();
		}
		
		public void setCalificacion(int valor){
			adicional.setCalificacion(valor);
		}
		public int responderPregunta(int pregunta){
			return adicional.responderPregunta(pregunta);
		}
		
		public void setEstrategia(EstrategiaDeComparacion e){
			adicional.setEstrategia(e);
		}
		
		public void setNombre(string nombre){
			adicional.setNombre(nombre);
		}
		
	}
}
