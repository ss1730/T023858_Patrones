using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.Stereo
{
    class OffStereo:ICommand
    {
        private readonly ConcreteRecivers.Stereo _stereo;
        public OffStereo(ConcreteRecivers.Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
           _stereo.On();
        }

       
    }
}
