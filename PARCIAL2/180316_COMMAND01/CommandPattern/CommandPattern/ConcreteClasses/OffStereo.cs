using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses
{
    class OffStereo:ICommand
    {
        private readonly Stereo _stereo;
        public OffStereo(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public void Recive()
        {
            throw new NotImplementedException();
        }
    }
}
