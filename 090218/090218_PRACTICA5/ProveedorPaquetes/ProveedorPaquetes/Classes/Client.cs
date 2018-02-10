using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveedorPaquetes.Classes
{
    class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public string OriginCountry { get; set; }
        public string DestinyCountry { get; set; }
        public DateTime ArrivalTime { get; set; }

        public Client(string name, string address, DateTime orderDate, string originCountry, string destinyCountry,
            DateTime arrivalTime,string postalProvider)
        {
            this.Name = name;
            this.Address = address;
            this.OrderDate = orderDate;
            this.OriginCountry = originCountry;
            this.DestinyCountry = destinyCountry;
            this.ArrivalTime = arrivalTime;
        }
    }
}
