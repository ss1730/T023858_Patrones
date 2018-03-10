using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FACTORY.ConcreteClasses;

namespace FACTORY
{
  public abstract class Pizza
   {
       
       public string Baking()
       {
           return "Cocinando";
       }

       public string Cooking()
       {
           return "Orneando";
       }

       public string Cutting()
       {
           return "Cortando";
       }

       public string Packing()
       {
           return "Empaquetando";
       }

       public string GetDescription()
       {
           return "";
       }
    }
}
