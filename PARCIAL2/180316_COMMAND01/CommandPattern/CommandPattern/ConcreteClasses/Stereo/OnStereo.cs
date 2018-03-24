using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.Stereo
{
    class OnStereo:ICommand
    {
        private readonly ConcreteRecivers.Stereo _stereo;

        public OnStereo(ConcreteRecivers.Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
           _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }

       
    }
}
