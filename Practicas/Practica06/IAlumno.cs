using System;

namespace Practica06
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno: Comparable
	{
		//ejercicio 06 -practica 04
		string getNombre();
		string mostrarCalificaciones();
		int getLegajo();
		int getDni();
		int getCalificacion();
		int responderPregunta(int pregunta);
		double getPromedio();
		void setCalificacion(int valor);
		void setEstrategia(EstrategiaDeComparacion e);
		void setNombre(string nombre);
	}
}
