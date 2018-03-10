using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FACTORY.ConcreteClasses;

namespace FACTORY
{
    public abstract class Factory
    {
        public  string Name;
        public string Description;
        private Pizza _myPizza;
        public Pizza CreatePizza(string pizza)
        {
            switch (pizza)
            {
                case "Peperoni":
                    _myPizza = new PizzaA();
                    
                    break;

                case "Italiana":
                    _myPizza = new PizzaB();
                    break;

                case "Chicago":
                    _myPizza = new PizzaC();
                    break;
            }
            return _myPizza;

        }

        public string NameFactory()
        {
            return Name;
        }
    }
}
