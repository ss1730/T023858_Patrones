using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Intefaces
{
    interface IObserver
    {
        void Update(double temp,double human, double presure);
    }
}
