using System;
using System.Collections.Generic;
namespace Practica01
{
	class Program
	{
		public static void Main(string[] args)
			{
			//ejercicio 14
			Pila pila=new Pila();
			Cola cola=new Cola();
			ColeccionMultiple multiple=new ColeccionMultiple(pila, cola);
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);
			
			//ejercicio 07
			/*
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			 */
				
			//ejercicio 09
			//informar(multiple)
			
			Console.ReadKey(true);
		}
		
		//ejercicio 05
		public static void llenar(Coleccionable col){
			for(int i=0; i<20; i++){
				Comparable aux=new Numero(2);
				col.agregar(aux);
			}
		}
	
		public static void informar(Coleccionable col){
			//ejercicio 06
			Console.WriteLine(col.cuantos());
			Console.WriteLine(col.minimo());
			Console.WriteLine(col.maximo());
			
			Console.Write("Ingrese el Legajo: ");
			int legajo=int.Parse(Console.ReadLine());
				
			/*Comparable aux = new Numero(2);*/
			
			Comparable aux = new Alumno("Braian", 45619054, legajo, 8);
			if(col.contiene(aux)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{Console.WriteLine("El elemento leído no está en la colección");}
		}
		
		//ejercicio 13
		public static void llenarAlumnos(Coleccionable col){
			for(int i=0; i<20; i++){
				Comparable aux=new Alumno("Braian", 45619054, 20123, 8);
				col.agregar(aux);
			}
		}
	}
	
	
}