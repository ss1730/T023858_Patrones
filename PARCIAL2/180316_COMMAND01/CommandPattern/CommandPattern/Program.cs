using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteClasses;
using CommandPattern.ConcreteRecivers;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WashMachine washMachine = new WashMachine();
            Stereo stereo = new Stereo();
            Invoke invoke = new Invoke();

            invoke.SetCommand(new OffStereo(stereo));
            invoke.ExecuteCommand();

            invoke.SetCommand(new OnStereo(stereo));
            invoke.ExecuteCommand();

            invoke.SetCommand(new OnWasMachine(washMachine));
            invoke.ExecuteCommand();

            invoke.SetCommand(new OffWashMachine(washMachine));
            invoke.ExecuteCommand();


            Console.ReadKey();
        }
    }
}
