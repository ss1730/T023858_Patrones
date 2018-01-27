using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class CaminarManos : IChanginBehavior
    {
        public void Caminar()
        {
            Console.WriteLine("Yo camino Con Manos");
        }
    }
}
