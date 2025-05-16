using System;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		//ejercicio 02 - practica 07
		
		//protected GeneradorDeDatosAleatorios generador=new GeneradorDeDatosAleatorios();
		//protected LectorDeDatos lector=new LectorDeDatos();
		protected Manejador responsables;
	
		public static Comparable crearAleatorio(int opcion){
			this.generarCadenaDeResponsables();
			FabricaDeComparables fabrica;
			
			switch(opcion){
					case 1: fabrica= new FabricaDeNumeros();break;
					case 2: fabrica= new FabricaDeAlumnos();break;
					case 3: fabrica= new FabricaDeProfesores();break;
					case 4: fabrica= new FabricaDeAlumnoEstudioso();break;
					case 5: fabrica= new FabricaDeDecorados();break;
					case 6: fabrica=new FabricaDeAlumnosProxy();break;
					case 7: fabrica=new FabricaDeCompuesto();break;
					default: throw new ArgumentException("Opción inválida: " + opcion);
			}
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			this.generarCadenaDeResponsables();
			
			FabricaDeComparables fabrica;
			
			switch(opcion){
					case 1: fabrica=new FabricaDeNumeros(); break;
					case 2: fabrica=new FabricaDeAlumnos(); break;
					case 3: fabrica= new FabricaDeProfesores();break;
					case 4: fabrica= new FabricaDeAlumnoEstudioso();break;
					case 5: fabrica= new FabricaDeDecorados();break;
					case 6: fabrica=new FabricaDeAlumnosProxy();break;
					case 7: fabrica=new FabricaDeCompuesto();break;
					default: throw new ArgumentException("Opción inválida: " + opcion);
			}
			return fabrica.crearPorTeclado();
			
		}
		
		public static Comparable crearPorArchivo(int opcion){
			this.generarCadenaDeResponsables();
			
			FabricaDeComparables fabrica;
				
			switch(opcion){
					case 1: fabrica=new FabricaDeNumeros(); break;
					case 2: fabrica=new FabricaDeAlumnos(); break;
					case 3: fabrica= new FabricaDeProfesores();break;
					case 4: fabrica= new FabricaDeAlumnoEstudioso();break;
					case 5: fabrica= new FabricaDeDecorados();break;
					case 6: fabrica=new FabricaDeAlumnosProxy();break;
					case 7: fabrica=new FabricaDeCompuesto();break;
					default: throw new ArgumentException("Opción inválida: " + opcion);
			}
			return fabrica.crearPorArchivo();
			
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		public abstract Comparable crearPorArchivo();
		
		//ejercicio 02 - practica 07
		protected void generarCadenaDeResponsables(){
			Manejador m = new GeneradorDeDatosAleatorios(null);
			m = new LectorDeDatos(m);
			m=new ObtencionDeDatos.LectorDeArchivos(m);
			this.responsables=m;
		}
		//no me deja ejecutarlo porque la versión de mi IDE
		
		//ejercicio 04 - practica 04
		/*
		private void generarCadenaDeResponsables(){
			Manejador m = GeneradorDeDatosAleatorios.getInstance(null);
			m =LectorDeDatos.getInstance(m);
			
			this.responsables=m;
		}
		*/
	}
}
