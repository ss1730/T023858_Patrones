namespace FACTORY.ConcreteFactoryClasses
{
    class SimpleFactory:Factory
    {
        string Name { get; set; }
        public SimpleFactory()
        {
            this.Name = "Simple Factory";
        }
        public void CreatePizza(Pizza pizza)
        {
            pizza.GetPizza();
        }

        public string NameFactory()
        {
            return Name;
        }

       
    }
}
