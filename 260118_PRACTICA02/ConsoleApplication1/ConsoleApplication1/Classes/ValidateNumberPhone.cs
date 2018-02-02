using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    class ValidateNumberPhone
    {
        public  string CheckNumberPhone(string number)
        {
            return Regex.Match(number, @"^(\+[0-9])$").Success ? "Telefono Correcto" : "Telefono Falso";
        }
    }
}
