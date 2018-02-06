using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Intefaces;

namespace Observer.Classes
{
    class DisplayB:IObserver,IDisplay
    {
        private double _temp;
        private double _human;
        private double _presure;
        public void Display(double temp, double humanity, double presure)
        {
            Console.WriteLine("Tempeture is: '{0}' Humanity is: '{1}' Presure is: '{2}'", temp, _human, presure);
        }

        public void Update(double temp, double human, double presure)
        {

            this._temp = temp;
            this._human = human;
            this._presure = presure;
            Display(_temp, _human, _presure);

        }
    }
}
