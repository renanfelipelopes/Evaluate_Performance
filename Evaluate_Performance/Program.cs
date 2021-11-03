using System;
using System.Globalization;
using System.Collections.Generic;
using Evaluate_Performance.Entities;
using Evaluate_Performance.Services;

namespace Evaluate_Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list);

            Console.WriteLine();
            Console.WriteLine("Most expansive:");
            Console.WriteLine(p);
        }
    }
}
