using System;

namespace CommandPattern.ConcreteRecivers
{
    class WashMachine
    {
       public void On()
        {
            Console.WriteLine("Ya Le Prendo");
        }

        public void Off()
        {
            Console.WriteLine("Ya Le Apago");
        }
    }
}
