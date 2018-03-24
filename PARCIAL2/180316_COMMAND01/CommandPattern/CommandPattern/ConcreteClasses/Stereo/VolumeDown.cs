using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.Stereo
{
    class VolumeDown:ICommand
    {
        private readonly ConcreteRecivers.Stereo _stereo;

        public VolumeDown(ConcreteRecivers.Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.VolumeDown();
        }

        public void Undo()
        {
            _stereo.VolumeUp();
        }

        
    }
}
