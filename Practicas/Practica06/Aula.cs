using System;
using MetodologíasDeProgramaciónI;

namespace Practica06
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		//ejercicio 03 - practica 05
		private Teacher teacher;
		
		public Aula()
		{
		}
		
		
		public void comenzar(){
			Console.WriteLine("Comenzando...");
			this.teacher=new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno){
			teacher.goToClass(new AlumnoAdapter(alumno));
		}
		
		public void claseLista(){
			teacher.teachingAClass();
		}
		
		
		
		
	}
}
