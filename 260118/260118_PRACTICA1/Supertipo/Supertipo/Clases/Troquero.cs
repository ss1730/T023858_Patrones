using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class Troquero: Person
    {
        public Troquero()
        {
            this.Age = 15;
            this.Name = " Troquero Nuevo";
            WalkingBehavior = new CaminarManos();
        }
    }
}
