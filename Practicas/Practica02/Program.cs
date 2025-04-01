using System;
using System.Collections.Generic;
namespace Practica02
{
	class Program
	{
		public static void Main(string[] args)
			{
			
			Pila pila=new Pila();
			Cola cola=new Cola();
			ColeccionMultiple multiple=new ColeccionMultiple(pila, cola);
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);

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
			
			Console.WriteLine(col.cuantos());
			Console.WriteLine(col.minimo());
			Console.WriteLine(col.maximo());
			
			Console.Write("Ingrese el Legajo: ");
			int legajo=int.Parse(Console.ReadLine());
				
			//ejercicio 02
			EstrategiaDeComparacion estrategia=new ComPorLegajo(); //puedo cambiarlo y que se compare por dni, nombre o promedio
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
				Comparable aux=new Alumno("Braian", 45619054, 20123, 8, estrategia);
				col.agregar(aux);
			}
		}
	}
	
	
}