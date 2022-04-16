using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the same city name one times

            List<string> cities = new List<string>() { "İstanbul", "Ankara", "Ankara", "İstanbul", "Ankara" };

            //Distinct method allows to use the same name element once
            cities = cities.Distinct().ToList(); 

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
