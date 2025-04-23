using System;

namespace Practica04
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno: Comparable
	{
		//ejercicio 06 -practica 04
		string getNombre();
		int getLegajo();
		int getDni();
		double getPromedio();
		string mostrarCalificaciones();
		int getCalificacion();
		void setCalificacion(int valor);
		int responderPregunta(int pregunta);
		void setEstrategia(EstrategiaDeComparacion e);
	}
}
