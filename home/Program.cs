using System;
using System.Buffers;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Schema;

namespace home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalprice= 0;


            if (count > 80 && flowers == "Roses")
            {
                totalprice = count * 5 * 0.9;
            }
            else if (flowers == "Roses")
            {
                totalprice = count * 5;
            }
            else if (count > 90 && flowers == "Dahlias")
            {
                totalprice = count * 3.8 * 0.85;
            }
            else if (flowers == "Dahlias")
            {
                totalprice = count * 3.8;
            }
            else if (count < 80 && flowers == "Tulips")
            {
                totalprice = count * 2.8 * 0.85;
            }
            else if (flowers == "Tulips")
            {
                totalprice = count * 2.8;
            }
            else if (count < 120 && flowers == "Narcissus")
            {
                totalprice = count * 3 * 1.15;
            }
            else if (flowers == "Narcissus")
            {
                totalprice = count * 3;
            }
            else if (count < 80 && flowers == "Gladiolus")
            {
                totalprice = count * 2.5 * 1.15;
            }
            else if (flowers == "Gladiolus")
            {
                totalprice = count * 2.5;
            }
            if (budget < totalprice)
            {
                Console.WriteLine($"Not enough money, you need {(totalprice - budget):2} leva more.");
            }
            else if (budget >= totalprice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {(budget - totalprice):F2} leva left.");
            }
        }
    }
}
