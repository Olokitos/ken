using System;
using System.Collections.Generic;

namespace Activity2
{
    public class Car
    { 
    public string Brand { get; set; }

        public string Color { get; set; }
        public string Price { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter new data? Y/N");
                if (Console.ReadLine().ToUpper() == "N") ;
                {
                    break;
                }
                Car car1 = new List <Car>();
                Console.WriteLine("Enter car Brand");
                car1.Brand= Console.ReadLine();
                Console.WriteLine("Enter car Color");
                car1.Color= Console.ReadLine();
                Console.WriteLine("Enter car Price");
                car1.Price= Console.ReadLine();
                List.Add(car1);

            }
           List.foreach (var(x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
                Console.WriteLine("=====================");

            });
        }
    }
}