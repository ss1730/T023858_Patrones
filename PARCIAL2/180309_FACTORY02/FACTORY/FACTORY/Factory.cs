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
        private  string _name;
        private Pizza _myPizza;
        public Pizza CreatePizza(string pizza)
        {
            switch (pizza)
            {
                case "Peperoni":
                    _myPizza = new PizzaA();
                    this._name = "Peperoni";
                    break;

                case "Italiana":
                    _myPizza = new PizzaB();
                    this._name = "Italiana";
                    break;

                case "Chicago":
                    _myPizza = new PizzaC();
                    this._name = "Chicago";
                    break;
            }
            return _myPizza;

        }

        public string NameFactory()
        {
            return _name;
        }
    }
}
