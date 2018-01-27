using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class Person
    {
        public string Name;
        public int Age;
        public  IChanginBehavior WalkingBehavior;


      
        public void Comer()
        {
            Console.WriteLine("Yo Como");

        }

        public  void Defecar()
        {
            Console.WriteLine("Yo Defeco");

        }

        public void Caminar()
        {
            WalkingBehavior.Caminar();

        }
    }
}
