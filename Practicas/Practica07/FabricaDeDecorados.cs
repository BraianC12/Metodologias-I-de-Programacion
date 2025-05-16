using System;

namespace Practica07
{
	/// <summary>
	/// Description of FabricaDeDecorados.
	/// </summary>
	public class FabricaDeDecorados: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			IAlumno alumno=(IAlumno) FabricaDeComparables.crearAleatorio(2);
			IAlumno decorado=new DecoradoPorLegajo(alumno);
			decorado=new DecoradoPorLetras(decorado);
			decorado=new DecoradoPorEstado(decorado);
			decorado=new DecoradoPorAstericos(decorado);
			return decorado;
				
		}
		
		public override Comparable crearPorTeclado(){
			IAlumno alumno=(IAlumno) FabricaDeComparables.crearAleatorio(2);
			IAlumno decorado=new DecoradoPorLegajo(alumno);
			decorado=new DecoradoPorLetras(decorado);
			decorado=new DecoradoPorEstado(decorado);
			decorado=new DecoradoPorAstericos(decorado);
			return decorado;
		}
		
		public override Comparable crearPorArchivo()
		{
			IAlumno alumno=(IAlumno) FabricaDeComparables.crearAleatorio(2);
			IAlumno decorado=new DecoradoPorLegajo(alumno);
			decorado=new DecoradoPorLetras(decorado);
			decorado=new DecoradoPorEstado(decorado);
			decorado=new DecoradoPorAstericos(decorado);
			return decorado;	
		}
	}
}
