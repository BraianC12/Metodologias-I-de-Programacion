using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace Practica04
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Teacher teacher=new Teacher();
			//ejercicio 04 - Practica 04
			
		/*	for(int i=0; i<20; i++){
				Alumno alumno;
				if (i<10){
					alumno=new Alumno("Braian", 45619045, "Carranza", 12345, 8.0);	
				}
				
				else{
					alumno=new AlumnoMuyEstudioso(1, "Matias", 22222, "Perez", 20021, 10.0);
				}
				
				Student alumnoAdaptado=new AlumnoAdapter(alumno);
				teacher.goToClass(alumnoAdaptado);
			}
			
			teacher.teachingAClass();
			*/
			
			//ejercicio 06 - practica 04
			/* 
			for(int i=0; i<20; i++){
				IAlumno decorado=(IAlumno) FabricaDeComparables.crearAleatorio(2);
				//IAlumno decoradoPorLegajo=new DecoradoPorLegajo(decorado); //decorado por legajo
				//IAlumno decoradoPorLetras=new DecoradoPorLetras(decorado); //decorado por letras 
				//IAlumno decoradoPorEstado=new DecoradoPorEstado(decorado); //
				IAlumno decoradoPorAstericos=new DecoradoPorAstericos(decorado);
				Student alumnoAdaptado=new AlumnoAdapter(decoradoPorAstericos);
				teacher.goToClass(alumnoAdaptado);
			}
			*/
			
			//ejercicio 07 - practica 04
			for(int i=0; i<20; i++){
				IAlumno decorado=(IAlumno) FabricaDeComparables.crearAleatorio(2);
				decorado=new DecoradoPorLegajo(decorado);
				decorado=new DecoradoPorLetras(decorado);
				decorado=new DecoradoPorEstado(decorado);
				decorado=new DecoradoPorAstericos(decorado);
				
				Student alumnoAdaptado=new AlumnoAdapter(decorado);
				teacher.goToClass(alumnoAdaptado);
			}
			
			teacher.teachingAClass();
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
			for(int i=0; i<20; i++){
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
				Alumno alumno=(Alumno)ite.actual(); //casteo para que el elemento comparable sea Alumno
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
	
	
