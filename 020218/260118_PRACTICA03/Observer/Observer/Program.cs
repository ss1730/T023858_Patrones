using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Classes;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weather = new WeatherData();
            weather.Add(new DisplayA());
            weather.Add(new DisplayB());
            weather.Add(new DisplayC());
            weather.SetData(300,140,50);
            weather.GetPresure();
            weather.GetTemp();
            weather.Notify();
            weather.SetData(400,14,32);
            weather.Notify();

            Console.ReadKey();
        }
    }
}
