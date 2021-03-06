﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProveedorPaquetes.Interfaces;

namespace ProveedorPaquetes.Classes
{
    class MEX:IObserver,IDisplay
    {
        private int UpdateTimer { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public string OriginCountry { get; set; }
        public string DestinyCountry { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string PostalProvider { get; set; }
        public int UpdateLastTime { get; set; }
        public MEX()
        {
            PostalProvider = "MEX";
            UpdateTimer = 1000;//12 horas
            UpdateLastTime = 0;
        }


        public void Update(string name, string address, DateTime orderDate, string originCountry, string destinyCountry,
            DateTime arrivaltime)
        {
            if (UpdateLastTime != 0)
            {
                this.Name = name;
                this.Address = address;
                this.OrderDate = orderDate;
                this.OriginCountry = originCountry;
                this.DestinyCountry = destinyCountry;
                this.ArrivalTime = arrivaltime;
                Thread.Sleep(UpdateTimer);
                Display(name, address, orderDate, originCountry, destinyCountry, arrivaltime);
            }
           
            
        }

        public void Display(string name, string address, DateTime orderDate, string originCountry, string destinyCountry,
            DateTime arrivaltime)
        {
            Console.WriteLine("Client is: '{0}' \n " +
                              "Package will be delivered in: '{1}' \n" +
                              "OrderDate  is: '{2}' \n" +
                              "From Country: '{3}' \n" +
                              "To Country '{4}' \n" +
                              "ArrivalDate: '{5}' \n" +
                              "Who is delivering?: '{6}' \n ", name, address, orderDate,originCountry,destinyCountry, arrivaltime,PostalProvider);
        }
    }
}
