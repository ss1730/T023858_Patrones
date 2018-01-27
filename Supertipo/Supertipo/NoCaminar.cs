using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class NoCaminar: IChanginBehavior
    {
        public void Caminar()
        {
            
            Console.WriteLine("Yo No Camino");
        }
    }
}
