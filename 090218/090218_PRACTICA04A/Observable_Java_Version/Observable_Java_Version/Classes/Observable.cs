using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observable_Java_Version.Interfaces;

namespace Observable_Java_Version.Classes
{
    class Observable
    {
        private Boolean _changed = false;
        public List<IObserver> Observers;

        protected Observable(bool changed, List<IObserver> observers)
        {
            this._changed = changed;
            Observers = observers;
        }

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("Se agrego alguien a la lista de Sujeto");
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("Se  Elimino a un Sujeto");
        }

        public void Notify(object o)
        {
            foreach (var obser in Observers)
            {
                obser.Update(this,o);
            }
        }

        public void Set()
        {
            _changed = true;
        }


        public void ClearChange()
        {
            _changed = false;
        }

       
    }
}
