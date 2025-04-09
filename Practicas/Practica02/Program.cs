using System;
using System.Collections.Generic;
namespace Practica02
{
	class Program
	{
		public static void Main(string[] args)
			{
			
			Pila pila=new Pila();
			llenarAlumnos(pila);
			cambiarEstrategia(pila, new ComPorNombre());
			Console.WriteLine("Comparacion por nombre: ");
			informar(pila);
			
			cambiarEstrategia(pila, new ComPorLegajo());
			Console.WriteLine("Comparacion por Legajo: ");
			informar(pila);
			
			cambiarEstrategia(pila, new ComPorPromedio());
			Console.WriteLine("Comparacion por promedio: ");
			informar(pila);
			
			cambiarEstrategia(pila, new ComPorDni());
			Console.WriteLine("Comparacion por dni: ");
			informar(pila);
			
			Console.ReadKey(true);
		}
	
		public static void informar(Coleccionable col){
			
			Console.WriteLine("Cuantos: " + col.cuantos());
			Console.WriteLine("Minimo: " +col.minimo());
			Console.WriteLine("Maximo: " +col.maximo());
			
			Console.Write("Ingrese el Legajo: ");
			int legajo=int.Parse(Console.ReadLine());
				
			//ejercicio 02
			EstrategiaDeComparacion estrategia=new ComPorDni(); //puedo cambiarlo y que se compare por dni, nombre o promedio
			Comparable aux = new Alumno("Braian", 45619054, legajo, 8, estrategia);
			if(col.contiene(aux)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{Console.WriteLine("El elemento leído no está en la colección");}
		}
		
		public static void llenarAlumnos(Coleccionable col){	
			for(int i=0; i<20; i++){
				//ejercicio 02
				EstrategiaDeComparacion estrategia=new ComPorLegajo();
				Comparable aux=new Alumno("Braian", 45619054, 20123, 8.0, estrategia);
				col.agregar(aux);
			}
			
			//ingresa manualmente, esto es para comprobar que las estrategias implementadas esten bien
			/*
			Console.Write("¿Cuantos alumnos debes ingresar?: ");
			int cantidad=int.Parse(Console.ReadLine());
			
			for(int i=0; i<cantidad; i++){
				Console.Write("\nNombre: ");
				string nombre=Console.ReadLine();
				
				Console.Write("DNI: ");
				int dni=int.Parse(Console.ReadLine());
				
				Console.Write("Legajo: ");
				int legajo=int.Parse(Console.ReadLine());
				
				Console.Write("Promedio: ");
				double promedio=double.Parse(Console.ReadLine());
				
				EstrategiaDeComparacion estrategia=new ComPorLegajo();
				Comparable alumno=new Alumno(nombre, dni, legajo, promedio, estrategia);
				col.agregar(alumno);
				Console.Write("nombre: " + nombre + " DNI: " + dni + " legajo: " + legajo + " promedio: " + promedio);
			}
			*/
			
		}
		
		//ejercicio 06
		public static void imprimirElementos(Coleccionable col){
			Iterador ite=col.crearIterador();
			
			ite.primero();
			while(!ite.fin()){
				Console.Write(ite.actual());
				ite.siguiente();
			}
			Console.WriteLine("Fin del recorrido");
		}
		
		//ejercicio 07
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
			
			
		}
		
	}
	
	
