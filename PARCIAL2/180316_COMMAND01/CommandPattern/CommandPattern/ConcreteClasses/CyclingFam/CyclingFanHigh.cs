using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.CyclingFam
{
    class CyclingFanHigh:ICommand
    {

        private readonly CyclingFan _cyclingFan;
        public CyclingFanHigh(CyclingFan cyclingFan)
        {
            _cyclingFan = cyclingFan;
        }
        public void Execute()
        {
            _cyclingFan.Slow();
        }

        public void Undo()
        {
            _cyclingFan.Off();
        }
    }
}
