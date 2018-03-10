using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY
{
    class SimpleFactory:Factory
    {
        string Name { get; set; }
        public SimpleFactory()
        {
            this.Name = "Simple Factory";
        }
        public void CreatePizza(Pizza pizza)
        {
            pizza.GetPizza(pizza.GetDescription());
        }

        public string NameFactory()
        {
            return Name;
        }

       
    }
}
