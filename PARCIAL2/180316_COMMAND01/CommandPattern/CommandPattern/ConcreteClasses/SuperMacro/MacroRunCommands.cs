using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses.SuperMacro
{
    class MacroRunCommands:ICommand
    {
        private readonly List<ICommand> _Icommands;
        public MacroRunCommands(List<ICommand> Icommands)
        {
            _Icommands = Icommands;
        }

        public void Execute()
        {
            foreach (var command in _Icommands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            _Icommands.Reverse();
            foreach (var commad in _Icommands)
            {
                commad.Undo();
            }
        }

    }
}
