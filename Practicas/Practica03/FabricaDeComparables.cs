using System;

namespace Practica03
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		//ejercicio 04/05
		protected GeneradorDeDatosAleatorios generador=new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector=new LectorDeDatos();
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica; 
			
			switch(opcion){
					case 1: fabrica= new FabricaDeNumeros();break;
					case 2: fabrica= new FabricaDeAlumnos();break;
					//ejercicio 09
					case 3: fabrica= new FabricaDeProfesores();break;
					default: throw new ArgumentException("Opción inválida: " + opcion);
			}
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			
			FabricaDeComparables fabrica;
			
			switch(opcion){
					case 1: fabrica=new FabricaDeNumeros(); break;
					case 2: fabrica=new FabricaDeAlumnos(); break;
					case 3: fabrica= new FabricaDeProfesores();break;
					default: throw new ArgumentException("Opción inválida: " + opcion);
			}
			return fabrica.crearPorTeclado();
			
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
