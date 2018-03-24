using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.CyclingFam
{
    class CyclingFanOff:ICommand
    {
        private readonly CyclingFan _cyclingFan;
        public CyclingFanOff(CyclingFan cyclingFan)
        {
            _cyclingFan = cyclingFan;
        }
        public void Execute()
        {
           _cyclingFan.Off();
        }

        public void Undo()
        {
           _cyclingFan.High();
        }
    }
}
