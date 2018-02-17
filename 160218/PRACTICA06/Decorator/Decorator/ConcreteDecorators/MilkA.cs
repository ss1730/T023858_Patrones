using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Abstract;

namespace Decorator.ConcreteDecorators
{
    internal class MilkA:Ingredients
    {
        private readonly Drink _dring;
        private  double Price { get; set; }
        private readonly string _descripction;
        public MilkA(Drink drink)
        {
            this._dring = drink;
            this._descripction = "Leche de Zanahoria";
        }

        public override string GetDescripcion()
        {
            return _dring.GetDescripcion()+_descripction;
        }

        public override double GetCost()
        {
            switch (_dring.Size)
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
            return _dring.GetCost()  + Price;
        }

      
    }
}
