using System;

namespace Practica05
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		
		protected GeneradorDeDatosAleatorios generador=new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector=new LectorDeDatos();
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica; 
			
			switch(opcion){
					case 1: fabrica= new FabricaDeNumeros();break;
					case 2: fabrica= new FabricaDeAlumnos();break;
					case 3: fabrica= new FabricaDeProfesores();break;
					case 4: fabrica= new FabricaDeAlumnoEstudioso();break;
					case 5: fabrica= new FabricaDeDecorados();break;
					case 6: fabrica=new FabricaDeAlumnosProxy();break;
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
					case 4: fabrica= new FabricaDeAlumnoEstudioso();break;
					case 5: fabrica= new FabricaDeDecorados();break;
					case 6: fabrica=new FabricaDeAlumnosProxy();break;
					default: throw new ArgumentException("Opción inválida: " + opcion);
			}
			return fabrica.crearPorTeclado();
			
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
