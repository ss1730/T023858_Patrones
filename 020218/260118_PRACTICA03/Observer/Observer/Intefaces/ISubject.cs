﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Intefaces
{
    interface ISubject
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();
    }
}
