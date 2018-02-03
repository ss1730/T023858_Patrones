using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApplication1.Interface;

namespace ConsoleApplication1.Classes
{
    class ValidateNumberPhone: IValidator
    {
       

        public string Validate(string validator)
        {
            return Regex.Match(validator, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success ? "Telefono Correcto" : "Telefono Falso"; ;
        }
    }
}
