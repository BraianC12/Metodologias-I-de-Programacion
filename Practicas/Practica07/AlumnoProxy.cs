using System;

namespace Practica07
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy: IAlumno
	{
		//ejercicio 01 - practica 05
		private IAlumno alumnoReal=null;
		private string nombre;
		private int opcion;
		
		public AlumnoProxy(string nombre, int opcion){
			this.nombre=nombre;
			this.opcion=opcion;
		}
		
		
		//implemento la interfaz IAlumno
		
		//metodo que el proxy puuede resolver
		public string getNombre(){
			return "Soy un Proxy: " + this.nombre;
		}
		
		public void setNombre(string nombre){
			this.nombre=nombre;
		}
		
		//metodos que el proxy no puede resolver
		public int getLegajo(){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			return this.alumnoReal.getLegajo();
		}
		
		public int getDni(){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			return this.alumnoReal.getDni();
		}
		
		public double getPromedio(){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			return this.alumnoReal.getPromedio();
		}
		
		public string mostrarCalificaciones(){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			return this.alumnoReal.mostrarCalificaciones();
		}
		
		
		public int getCalificacion(){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			return this.alumnoReal.getCalificacion();
		}
		
		public void setCalificacion(int valor){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			this.alumnoReal.setCalificacion(valor);
		
		}
		
		public int responderPregunta(int pregunta){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			
			return this.alumnoReal.responderPregunta(pregunta);
		}
		
		public void setEstrategia(EstrategiaDeComparacion e){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			this.alumnoReal.setEstrategia(e);
		}
		
		public bool sosIgual(Comparable c){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			
			return this.alumnoReal.sosIgual(c);
		}
		
		public bool sosMenor(Comparable c){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			
			return this.alumnoReal.sosMenor(c);
		}
		
		public bool sosMayor(Comparable c){
			if(this.alumnoReal == null){
				this.alumnoReal= (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				this.alumnoReal.setNombre(this.nombre);
			}
			
			return this.alumnoReal.sosMayor(c);
		}

	}
}
