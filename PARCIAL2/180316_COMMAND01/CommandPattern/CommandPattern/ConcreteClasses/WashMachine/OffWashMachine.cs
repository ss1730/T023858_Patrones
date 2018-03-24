using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.WashMachine
{
    class OffWashMachine:ICommand
    {
        private readonly ConcreteRecivers.WashMachine _washMachine;

        public OffWashMachine(ConcreteRecivers.WashMachine washMachine)
        {
            _washMachine = washMachine;
        }
        public void Execute()
        {
            _washMachine.On();
        }

        public void Undo()
        {
            _washMachine.On();

        }

    }
}
