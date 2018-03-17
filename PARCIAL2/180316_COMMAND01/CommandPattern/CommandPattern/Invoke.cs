using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    class Invoke
    {
        private ICommand _slot;
        
        public void SetCommand(ICommand myCommand)
        {
            _slot= myCommand;
            
        }

        public void ExecuteCommand()
        {
           _slot.Execute();
        }

       
    }
}
