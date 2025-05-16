using System;

namespace Practica07
{
	/// <summary>
	/// Description of Manejador.
	/// </summary>
	public abstract class Manejador
	{
		//ejercicio 01 - practica 07
		protected Manejador sucesor;
		
		public Manejador(Manejador sucesor)
		{
			this.sucesor=sucesor;
		}
		
		//implementar la interfaz publica de todos los majeadores concretos
		
		
		//interfaz de GeneradorDeDatosAleatorios
		public virtual int numeroAleatorio(int max){
			if(sucesor!=null){
				return sucesor.numeroAleatorio(max);
			}
			return 0;
		}
		
		public virtual string stringAleatorio(int cantidad=5){
			if(sucesor!=null){
				return sucesor.stringAleatorio(cantidad);
			}
			return "";
		}
		
		//interfaz public de LectorDeDatos
		public virtual int numeroPorTeclado(){
			if(sucesor!=null){
				return sucesor.numeroPorTeclado();
			}
			return 0;
		}
		
		public virtual string stringPorTeclado(){
			if(sucesor!=null){
				return sucesor.stringPorTeclado();
			}
			return "";
		}
		
		//interfaz public de Obtencion de datos
		//ejercicio 03 - practica 07
		public virtual double numeroDesdeArchivo(double max){
			if(sucesor!=null){
				return sucesor.numeroDesdeArchivo(max);
			}
			return 0;
		}
		
		public virtual string stringDesdeArchivo(int cant){
			if(sucesor!=null){
				return sucesor.stringDesdeArchivo(cant);
			}
			return "";
		}
			
		
	}
}
