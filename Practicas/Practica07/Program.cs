using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace Practica07
{
	class Program
	{
		public static void Main(string[] args)
		{			
			Teacher teacher=new Teacher();
			Student student;
			//ejercicio 04 - practica 04
			GeneradorDeDatosAleatorios gen1= GeneradorDeDatosAleatorios.getInstance(null);
			GeneradorDeDatosAleatorios gen2= GeneradorDeDatosAleatorios.getInstance(null);
			GeneradorDeDatosAleatorios gen3= GeneradorDeDatosAleatorios.getInstance(null);
			
			
			//ejercicio 03 - practica 03
			/*
			//alunos aleatoriamente
			for(int i=0; i<5; i++){
				IAlumno alumnoEstudioso=(IAlumno)FabricaDeComparables.crearPorTeclado(2);
				student=new AlumnoAdapter(alumno);
				teacher.goToClass();
			}
			
			//alumnos estudioso por teclado
			for(int i=0; i<2; i++){
				IAlumno alumnoEstudioso=(IAlumno)FabricaDeComparables.crearPorTeclado(6);
				student=new AlumnoAdapter(alumno);
				teacher.goToClass();
			}
			
			//compuesto por 5 alumnos desde archivo
			AlumnoCompuesto compuesto;
			for(int i=0; i<5; i++){
				AlumnoProxy proxy= (AlumnoProxy)FabricaDeComparables.crearPorArchivo(2);
				compuesto.agregarHijo(proxy);
			}
			
			student=new AlumnoAdapter(compuesto);
			teacher.goToClass(student);
			
			teacher.teachingAClass();
			*/
			
			Console.ReadKey();
			
		}
	
		
		
		public static void informar(Coleccionable col, int opcion){
			Console.WriteLine("Cuantos: " + col.cuantos());
			Console.WriteLine("Minimo: " +col.minimo());
			Console.WriteLine("Maximo: " +col.maximo());
			
			Comparable c=FabricaDeComparables.crearPorTeclado(opcion);
			if(col.contiene(c)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{Console.WriteLine("El elemento leído no está en la colección");}
		}
		
		public static void llenar(Coleccionable col, int opcion){	
			for(int i=0; i<=20; i++){
				Comparable c= FabricaDeComparables.crearAleatorio(opcion);
				col.agregar(c);
			}			
		}
		
		public static void imprimirElementos(Coleccionable col){
			Iterador ite=col.crearIterador();
			
			ite.primero();
			while(!ite.fin()){
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			Console.WriteLine("Fin del recorrido");
		}
		
		
		public static void cambiarEstrategia(Coleccionable c, EstrategiaDeComparacion e){
			Iterador ite=c.crearIterador();
			ite.primero();
			
			while(!ite.fin()){
				IAlumno alumno=(IAlumno)ite.actual(); //casteo para que el elemento comparable sea Alumno
				alumno.setEstrategia(e); //cambia la estrategia de comparacion
        		Console.WriteLine("Cambiando estrategia de: " + alumno);
				
				ite.siguiente();
				}
			}
		
		
		public static void dictadoDeClases(Profesor p){
			for(int i=0; i<5; i++){
				p.hablarALaclase();
				p.escribirAlPizarron();
			}
		}
		}
		
	}
	
	
