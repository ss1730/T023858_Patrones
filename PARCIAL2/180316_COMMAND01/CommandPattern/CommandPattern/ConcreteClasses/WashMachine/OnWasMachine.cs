using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.WashMachine
{
    class OnWasMachine:ICommand
    {
        private readonly ConcreteRecivers.WashMachine _washMachine;

        public OnWasMachine(ConcreteRecivers.WashMachine washMachine)
        {
            _washMachine = washMachine;
        }
        public void Execute()
        {
           _washMachine.On();
        }

        public void Undo()
        {
            _washMachine.Off();
        }
        
    }
}
