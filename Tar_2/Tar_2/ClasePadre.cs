using System;

namespace Tar_2
{
	public class ClasePadre
	{
		public double num1, num2;
		private string nom;
		public ClasePadre ()
		{
		}

		public string mostrarNombre(){
			Console.Write("Ingrese su nombre: ");
			nom = Console.ReadLine();
			return nom;
		}

		public virtual void suma ()
		{
			Console.Clear();
			Console.WriteLine("Bienvenido: {0}", this.nom );
			Console.Write ("Ingrese un numero a sumar: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write ("Ingrese un numero a sumar: ");
			num2 = Convert.ToDouble(Console.ReadLine());
		}
	}
}

