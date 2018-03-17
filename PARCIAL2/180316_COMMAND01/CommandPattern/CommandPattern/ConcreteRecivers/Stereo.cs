using System;
using CommandPattern.ConcreteClasses;

namespace CommandPattern.ConcreteRecivers
{
    class Stereo
    {
       public void On()
        {
            Console.WriteLine("Ya Le Prendo");
        }

        public void Off()
        {
            Console.WriteLine("Ya Le Apago");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Ya Le Subo");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Ya Le Bajo");
        }
    }
}
