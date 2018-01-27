using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SuperTipo");

            Estudiante estudiante  = new Estudiante();
            Console.WriteLine("Mi Nombre es: "+estudiante.Name+" y soy estudiante");
            Console.WriteLine("Mi edad es: "+estudiante.Age);
            Console.Write("Y Yo Camino: ");
            estudiante.WalkingBehavior.Caminar();
            
            Troquero troquero = new Troquero();
            Console.WriteLine("Mi Nombre es: " + troquero.Name + " y soy estudiante");
            Console.WriteLine("Mi edad es: " + troquero.Age);
            Console.Write("Y Yo Camino: ");
            troquero.WalkingBehavior.Caminar();
            
            Profesor profesor = new Profesor();
            Console.WriteLine("Mi Nombre es: " + profesor.Name + " y soy estudiante");
            Console.WriteLine("Mi edad es: " + profesor.Age);
            Console.Write("Y Yo Camino: ");
            profesor.WalkingBehavior.Caminar();

            Console.ReadLine();

        }
    }
}
