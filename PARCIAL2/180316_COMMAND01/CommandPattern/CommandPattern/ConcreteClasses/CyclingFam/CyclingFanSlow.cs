using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.CyclingFam
{
    class CyclingFanSlow:ICommand
    {
        private readonly CyclingFan _cyclingFan;
        public CyclingFanSlow(CyclingFan cyclingFan)
        {
            _cyclingFan = cyclingFan;
        }
        public void Execute()
        {
           _cyclingFan.Slow();
        }

        public void Undo()
        {
           _cyclingFan.High();
        }
    }
}
