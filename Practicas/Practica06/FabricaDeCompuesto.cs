
using System;

namespace Practica06
{
	/// <summary>
	/// Description of FabricaDeCompuesto.
	/// </summary>
	public class FabricaDeCompuesto: FabricaDeComparables
	{
		//ejercicio 02 - practica 06
		public override Comparable crearAleatorio(){
			AlumnoCompuesto compuesto=new AlumnoCompuesto();
			for(int i=0; i<5; i++){
				AlumnoProxy proxy=(AlumnoProxy)FabricaDeComparables.crearAleatorio(6); //opcion para crear alumnos proxys
				compuesto.agregarHijo(proxy);
			}
			return compuesto;
		}
		
		public override Comparable crearPorTeclado(){
			AlumnoCompuesto compuesto=new AlumnoCompuesto();
			for(int i=0; i<5; i++){
				AlumnoProxy proxy=(AlumnoProxy)FabricaDeComparables.crearPorTeclado(6);
				compuesto.agregarHijo(proxy);
			}
			return compuesto;
		}
		
		
	}
}
