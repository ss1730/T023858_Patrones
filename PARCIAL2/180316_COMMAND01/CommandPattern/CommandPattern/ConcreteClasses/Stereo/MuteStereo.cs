using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.Stereo
{
    class MuteStereo:ICommand
    {
        private readonly ConcreteRecivers.Stereo _stereo;
        public MuteStereo(ConcreteRecivers.Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.VolumeUp();
        }

       
    }
}
