using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FACTORY.ConcreteFactoryClasses;

namespace FACTORY
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory pizzaServe = new ChicagoFactory();
            pizzaServe.CreatePizza("Peperoni");


            Console.ReadKey();
        }
    }
}
