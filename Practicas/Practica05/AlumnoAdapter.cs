using System;
using MetodologíasDeProgramaciónI;

namespace Practica05
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter: Student
	{
		//ejercicio 03 - practica 04
		private IAlumno alumno;
		public AlumnoAdapter(IAlumno alumno)
		{
			this.alumno=alumno;
		}
		
		//implementacion de la interfaz student
		public string getName(){
			return alumno.getNombre();
		}
		
				
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score){
			alumno.setCalificacion(score);
		}
		
		public string showResult(){
			return alumno.mostrarCalificaciones();
		}
		
		public bool equals(Student student){
			return alumno.sosIgual(((AlumnoAdapter)student).alumno);
		}
		
		public bool lessThan(Student student){
			return alumno.sosMenor(((AlumnoAdapter)student).alumno);
		}
		
		public bool greaterThan(Student student){
			return alumno.sosMayor(((AlumnoAdapter)student).alumno);
		}
		
		public override string ToString()
		{
			return alumno.ToString();
		}

	
	}
}
