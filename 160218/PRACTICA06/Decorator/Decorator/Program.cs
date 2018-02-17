using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Abstract;
using Decorator.ConcreteClasses;
using Decorator.ConcreteDecorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
          Drink drink = new PayeLatte();
            drink.Size = 2;
            Console.WriteLine("Costo: "+drink.GetCost()+" Contenido: "+drink.GetDescripcion());
            drink = new MilkA(drink);
            Console.WriteLine("Costo: " + drink.GetCost() + " Contenido: " + drink.GetDescripcion());
            drink = new MilkB(drink);
            Console.WriteLine("Costo: " + drink.GetCost() + " Contenido: " + drink.GetDescripcion());
            Console.ReadKey();
        }
    }
}
