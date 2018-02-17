using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Abstract;

namespace Decorator.ConcreteClasses
{
    internal class PayucaMocha: Drink
    {
        private double Price { get; set; }
        private string Descripcion { get; }
        private int _size;

        public PayucaMocha()
        {
            this.Descripcion = "PayucaExpress Cafe";
        }


        public override string GetDescripcion()
        {
            return Descripcion;
        }

        public override double GetCost()
        {
            switch (_size)
            {
                case 1:
                    Price = 10;
                    break;

                case 2:
                    Price = 20;
                    break;

                case 3:
                    Price = 30;
                    break;

                default:
                    Price = 10;
                    break;
            }
            return Price;
        }
    }
}
