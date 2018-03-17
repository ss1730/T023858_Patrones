namespace FACTORY.ConcreteFactoryClasses
{
    class SimpleFactory:Factory
    {
        private string _factoryName { get; set; }
        public SimpleFactory()
        {
            this._factoryName = "Simple Factory";
        }
        public void GetPizza(Pizza pizza)
        {
            pizza.GetPizza();
        }

        public string NameFactory()
        {
            return _factoryName;
        }

       
    }
}
