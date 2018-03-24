using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.CyclingFam
{
    class CyclingFanMedium:ICommand
    {
        private readonly CyclingFan _cyclingFan;
        public CyclingFanMedium(CyclingFan cyclingFan)
        {
            _cyclingFan = cyclingFan;
        }
        public void Execute()
        {
           _cyclingFan.Medium();
        }

        public void Undo()
        {
            _cyclingFan.Slow();
        }
    }
}
