using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses
{
    class OnStereo:ICommand
    {
        private readonly Stereo _stereo;

        public OnStereo(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
           _stereo.On();
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
