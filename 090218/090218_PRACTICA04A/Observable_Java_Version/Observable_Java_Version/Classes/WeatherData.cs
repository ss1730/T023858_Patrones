using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observable_Java_Version.Interfaces;

namespace Observable_Java_Version.Classes
{
    class WeatherData: Observable
    {

        private double Temp { get; }
        private double Presure { get; }
        private double Humanity { get;  }

        protected WeatherData(bool changed, List<IObserver> observers, double temp, double presure, double humanity) : base(changed, observers)
        {
            Temp = temp;
            Presure = presure;
            Humanity = humanity;
        }

        public double GetTemp()
        {
            return Temp;
        }

        public double GetPresure()
        {

            return Presure;

        }

        public double GetHumanity()
        {
            return Humanity;
        }

        public void Measurement(object obj)
        {
            Set();
            Notify(obj);
        }


       
    }

}
