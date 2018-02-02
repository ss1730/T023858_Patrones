using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Interface;

namespace ConsoleApplication1.Classes
{
    class FromField : IValidator
    {
        private string _value;

     
        public bool Validate(string validator)
        {
            throw new NotImplementedException();
        }
    }
}
