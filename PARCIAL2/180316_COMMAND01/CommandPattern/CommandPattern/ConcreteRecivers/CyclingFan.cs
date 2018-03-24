using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteRecivers
{
    class CyclingFan
    {
        private readonly int _speed;

       


        public void Slow()
        {
            Console.WriteLine("Ya voy lento pero seguro");
        }

        public void Medium()
        {
            Console.WriteLine("Ya voy medio a prisa");
        }

        public void High()
        {
            Console.WriteLine("Ya voy bien rapido");
        }

        public void Off()
        {
            Console.WriteLine("Ya no voy por que me apagron.");
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
