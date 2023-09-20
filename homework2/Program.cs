using System.ComponentModel.Design;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());
            double incom = 0.0;

            if (type == "Premiere")
            {
                incom = row * colum * 12;
            }
            else if  ( type == "Normal")
                        {
                incom = row * colum * 7.5;
                    }
            else if (type == "Discount")
            { incom = row * colum * 5;
            }
            Console.WriteLine($"{incom:F2} leva");
        }
    }
}