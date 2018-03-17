﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteRecivers;
using CommandPattern.Interfaces;

namespace CommandPattern.ConcreteClasses
{
    class OnWasMachine:ICommand
    {
        private readonly WashMachine _washMachine;

        public OnWasMachine(WashMachine washMachine)
        {
            _washMachine = washMachine;
        }
        public void Execute()
        {
           _washMachine.On();
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
