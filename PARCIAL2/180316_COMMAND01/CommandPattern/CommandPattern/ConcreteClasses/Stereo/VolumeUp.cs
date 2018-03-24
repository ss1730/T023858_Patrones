using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.Stereo
{
    class VolumeUp:ICommand
    {
        private readonly ConcreteRecivers.Stereo _stereo;

        public VolumeUp(ConcreteRecivers.Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.VolumeDown();
        }

        public void Undo()
        {
            _stereo.VolumeDown();
        }

     
    }
}
