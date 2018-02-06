using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class Profesor: Person
    {
        public Profesor()
        {
            this.Age = 10;
            this.Name = "Profesor Jose";
            WalkingBehavior = new NoCaminar();
        }
    }
}
