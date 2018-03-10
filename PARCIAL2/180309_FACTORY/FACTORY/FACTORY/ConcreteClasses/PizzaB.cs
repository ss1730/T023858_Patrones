using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY
{
    class PizzaB:Pizza
    {
        public string Name;
        public string Description;

        public PizzaB()
        {
            this.Name = "Italiana";
            this.Description = "Pues llevo muchas cosas mas";
        }

        
    }
}
