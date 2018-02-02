using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
    class ValidateEmail
    {
        public string CheckEmail(string email)
        {
            return Regex.Match(email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*").Success ? "Telefono Correcto" : "Telefono Falso";
        }
    }
}
