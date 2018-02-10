using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observable_Java_Version.Interfaces;

namespace Observable_Java_Version.Classes
{
    class DisplayA : IObserver
    {
     

        public void Display(object o)
        {
            foreach (var data in o.GetType().GetProperties())
            {
                Console.WriteLine("Data Is : ", data);
            }
           
        }


        public void Update(Observable observable, object obj)
        {
            
            Display(obj);
        }
    }
}
