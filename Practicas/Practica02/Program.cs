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
			
			//comente esta parte del codigo porque me genera 20 elementos aleatorios para comprobar
			//si la estrategias implementadas en la Main estaban bien, como no sabia hacerlas 
			//le pedi a chatGPT que me genere 20 usuarios al azar, solamnte para ver si estaba bien las implementacion realizadas anteriormente
			/*
			  string[] nombres = { "Juan", "Ana", "Luis", "Sofía", "Carlos", "Martina", "Ezequiel", "Laura", "Pedro", "Mara" };
    		  Random rnd = new Random();
			
			    for (int i = 0; i < 20; i++)
			    {
			        string nombre = nombres[rnd.Next(nombres.Length)];
			        int dni = rnd.Next(40000000, 50000000);  // DNI aleatorio entre 40M y 50M
			        int legajo = rnd.Next(10000, 20000);    // Legajo entre 10000 y 20000
			        double promedio = Math.Round(rnd.NextDouble() * 10, 2); // Promedio entre 0 y 10
			
			        EstrategiaDeComparacion estrategia = new ComPorLegajo();
			        Comparable aux = new Alumno(nombre, dni, legajo, promedio, estrategia);
			        col.agregar(aux);
			        Console.WriteLine("Nombre: " + nombre + " dni: " + dni + " legajo: " +legajo + " promedio: " + promedio);
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
	
	
