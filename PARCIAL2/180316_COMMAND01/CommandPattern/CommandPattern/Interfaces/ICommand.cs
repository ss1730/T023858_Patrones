namespace CommandPattern.Interfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
        void Recive();
    }
}
