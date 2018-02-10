using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveedorPaquetes.Interfaces
{
    interface IDisplay
    {
        void Display(string name, string address, DateTime orderDate, string originCountry, string destinyCountry, DateTime arrivaltime);
    }
}
