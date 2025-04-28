using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace Practica05
{
	class Program
	{
		public static void Main(string[] args)
		{			
			/*
			Teacher teacher=new Teacher();
			Student student;
			IAlumno alumno;
			//ejercicio 02 - practica 05
			for(int i=0; i<20; i++){
				if(i<10){
					alumno=new AlumnoProxy("PEPITO", 2);
					student=new AlumnoAdapter(alumno);
				}
				else{
					alumno=new AlumnoProxy("BRAIAN", 2);
					student=new AlumnoAdapter(alumno);
				}
				teacher.goToClass(student);
			}
			teacher.teachingAClass();
			*/
			
			//ejercicio 10 - practica 05
			Pila pila=new Pila();
			//Cola cola=new Cola();
			//Conjunto conjunto=new Conjunto();
			Aula aula=new Aula();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			llenar(pila, 2); //alumnos normales
			llenar(pila, 4); //alumnos estudiosos 
			
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
	
	
