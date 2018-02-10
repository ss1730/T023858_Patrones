using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observable_Java_Version.Classes;

namespace Observable_Java_Version.Interfaces
{
    interface IObserver
    {
        void Update(Observable observable,object obj);
    }
}
