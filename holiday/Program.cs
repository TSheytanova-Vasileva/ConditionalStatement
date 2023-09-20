using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalbudget = 0.00;
            string destination = "";
            string holidayType = "";





            if (season == "summer" && budget <= 100.00)
            {
                destination = "Bulgaria";

                holidayType = "Camp";
                totalbudget = budget * 0.3;
            }
            else if (season == "winter" && budget <= 100.00)
            {
                destination = "Bulgaria";
                totalbudget = budget * 0.7;
                holidayType = "Hotel";
            }

            else if (season == "summer" && budget <= 1000 && budget > 100.00)

            {
                destination = "Balkans";
                totalbudget = budget * 0.4;
                holidayType = "Camp";
            }
            else if (budget <= 1000.00)
            {
                destination = "Balkans";
                totalbudget = budget * 0.8;
                holidayType = "Hotel";
            }
            else if (season == "summer" && budget > 1000.00)
            {
                destination = "Europe";
                holidayType = "Hotel";
                totalbudget = budget * 0.9;
                

            }                          
            
            
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {totalbudget:F2}");
        }
    }
}