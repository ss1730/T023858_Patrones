using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProveedorPaquetes.Classes;

namespace ProveedorPaquetes
{
    class Program
    {
        static void Main(string[] args)
        {
            PostalServices client1 = new PostalServices();
            client1.Add(new DHL());
            client1.SetData("Jose","Esa del ese del aquel",DateTime.Now, "Mexico","USA",DateTime.Today);
            client1.Measurement();
            PostalServices client2 = new PostalServices();
            client2.Add(new Fedex());
            client2.SetData("Mario", "Esa del ese del aquel", DateTime.Now, "Mexico", "USA", DateTime.Today);
            client2.Measurement();
            PostalServices client3 = new PostalServices();
            client3.Add(new MEX());
            client3.SetData("Pedro", "Esa del ese del aquel", DateTime.Now, "Mexico", "USA", DateTime.Today);
            client3.Notify();
            client3.Add(new DHL());
            client3.SetData("Pedro", "Esa del ese del aquel", DateTime.Now, "USA", "mexico", DateTime.Today);
            client3.Notify();
            

            Console.ReadKey();
        }
    }
}
