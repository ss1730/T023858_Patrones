using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Interface;

namespace ConsoleApplication1.Classes
{
    abstract class FromField : IValidator
    {
        public IValidator Validator;

     
        public string Validate(string validator)
        {
            return "validar";
        }
    }
}
