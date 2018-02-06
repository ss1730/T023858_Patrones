using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Classes;
using ConsoleApplication1.SuperTypes;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Valedor Validator");
                Console.WriteLine("Ingrese su Cadena de Texto");
                var cadena = Console.ReadLine();
                Console.WriteLine("1.-Validar Correo");
                Console.WriteLine("2.-Validar # de Telefono");
                Console.WriteLine("Con que opcion desea Validar su Candena? ");
                var temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        TextField validator = new TextField();
                        Console.WriteLine(validator.Validate(cadena));
                        Console.ReadKey();
                        break;

                    case "2":
                        TextField validator2 = new TextField();
                        Console.WriteLine(validator2.Validator.Validate(cadena));
                        Console.ReadKey();
                        break;

                    case "3":

                        break;


                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
                Console.WriteLine("Desea otra opcion? 1.->Si 2.->No");
                repeat = Console.ReadLine();
            } while (repeat == "1");
        }
    }
}
