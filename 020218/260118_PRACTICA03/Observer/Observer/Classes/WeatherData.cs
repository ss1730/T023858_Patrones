using System;
using System.Collections.Generic;
using Observer.Intefaces;

namespace Observer.Classes
{
    class WeatherData:ISubject
    {
        private readonly List<IObserver> _observers;
        private double Temp { get; set; }
        private double Human { get; set; }
        private double Presure { get; set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public double GetTemp()
        {
            return Temp;
        }

        public double GetPresure()
        {

            return Presure;

        }

        public double GetHumanity()
        {
            return Presure;
        }

        public void Measurement()
        {
            Notify();
        }

        public void SetData(double temp, double humanity, double presure)
        {
            this.Temp = temp;
            this.Human = humanity;
            this.Presure = presure;

        }

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Se agrego alguien a la lista de Sujeto");
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Se  Elimino a un Sujeto");
        }

        public void Notify()
        {
            foreach (var obser in _observers)
            {
                obser.Update(GetTemp(),GetHumanity(),GetPresure());
            }
        }

       
    }
}
