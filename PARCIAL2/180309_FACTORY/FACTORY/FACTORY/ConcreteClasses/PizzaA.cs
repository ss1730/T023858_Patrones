using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY
{
    class PizzaA:Pizza
    {
        public string Name;
        public string Description;

        public PizzaA()
        {
            Name = "Peperoni";
            this.Description = "Pues llevo muchas cosas";
        }
    }
}
