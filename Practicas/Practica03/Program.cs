using System;
using System.Collections.Generic;
namespace Practica03
{
	class Program
	{
		public static void Main(string[] args)
		{	
			/*
			//ejercicio 06
			Coleccionable col= new Pila();
			int opcion=3;
			llenar(col, opcion);
			imprimirElementos(col);
			informar(col, opcion);
			*/
			
			//ejercicio 14
			Profesor profe=new Profesor("Braian", 45619054, 5, new ComPorAntiguedad());
			Pila pila=new Pila();
			
			llenar (pila, 2);
			Iterador ite=pila.crearIterador();
			ite.primero();
			
			while(!ite.fin()){
				profe.agregarObservador((Observador)ite.actual());
				ite.siguiente();
			}
			
			dictadoDeClases(profe);
			
			
			Console.ReadKey(true);
		}
	
		public static void informar(Coleccionable col, int opcion){
			//ejercicio 06
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
			//ejercicio 06
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
		
		//ejercicio 13
		public static void dictadoDeClases(Profesor p){
			for(int i=0; i<5; i++){
				p.hablarALaclase();
				p.escribirAlPizarron();
			}
		}
		}
		
	}
	
	
