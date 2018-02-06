using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApplication1.Interface;

namespace ConsoleApplication1.Classes
{
    class ValidateEmail: IValidator
    {
     
        public string Validate(string validator)
        {
            return Regex.Match(validator, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*").Success ? "Telefono Correcto" : "Telefono Falso";
        }
    }
}
