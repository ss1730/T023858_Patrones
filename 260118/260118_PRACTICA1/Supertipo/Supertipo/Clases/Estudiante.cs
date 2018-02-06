using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertipo
{
    class Estudiante : Person
    {
        public Estudiante()
        {
            this.Age = 13;
            this.Name = "Estudiante Mariano";
            WalkingBehavior = new CaminarDosPies();
        }
       

       
    }
}
