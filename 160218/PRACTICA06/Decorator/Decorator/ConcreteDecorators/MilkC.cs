using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Abstract;

namespace Decorator.ConcreteDecorators
{
    internal class MilkC:Ingredients
    {
        private readonly Drink _drink;
        private  double Price { get; set; }
        private readonly string _descripction;
        public MilkC(Drink dring)
        {
            this._drink = dring;
            this._descripction = "Leche de varios";
        }

     

        public override string GetDescripcion()
        {
            return _drink.GetDescripcion() + _descripction;
        }

        public override double GetCost()
        {
            switch (_drink.Size)
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
            return _drink.GetCost() + Price;
        }
    }
}
