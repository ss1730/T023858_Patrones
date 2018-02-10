using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ProveedorPaquetes.Interfaces;

namespace ProveedorPaquetes.Classes
{
    class PostalServices:IProvider
    {
        private readonly List<IObserver> _observers;
      
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public string OriginCountry { get; set; }
        public string DestinyCountry { get; set; }
        public DateTime ArrivalTime { get; set; }
        public PostalServices()
        {
            _observers = new List<IObserver>();
           
        }

        public string GetNameClient()
        {
            return Name;
        }

        public string GetAddress()
        {

            return Address;

        }

        public DateTime GetOrderDate()
        {

            return OrderDate;

        }

        public string GetOriginCountry()
        {

            return OriginCountry;

        }

        public string GetDestinyCountry()
        {

            return DestinyCountry;

        }

        public DateTime GetArrivalDate()
        {

            return ArrivalTime;

        }

        public void Measurement()
        {
            Notify();
        }

        public void SetData(string name, string address, DateTime orderDateTime, string originCountry,
            string destinyCountry, DateTime arrivalDateTime)
        {
            this.Name = name;
            this.Address = address;
            this.OrderDate = orderDateTime;
            this.OriginCountry = originCountry;
            this.DestinyCountry = destinyCountry;
            this.ArrivalTime = arrivalDateTime;
        }
       

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Se agrego alguien a la lista de Providers");
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Se  Elimino a Sujeto");
        }

        public void Notify()
        {
            foreach (var obser in _observers)
            {
                obser.Update(GetNameClient(),GetAddress(),GetOrderDate(),GetOriginCountry(),GetDestinyCountry(),GetArrivalDate());
            }
        }

    }


}
