namespace flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalprice = 0;

            switch (flowers)
            { 
                case "Roses":

                totalprice = count * 5;
                if (count > 80)
                    totalprice = totalprice * 0.9;
                break;
            case "Dahlias":

                totalprice = count * 3.8;
                if (count > 90)
                    totalprice = totalprice * 0.85;
                break;
            case "Tulips":

                totalprice = count * 2.8;
                if (count > 80)
                    totalprice = totalprice * 0.85;
                break;
            case "Narcissus":

                totalprice = count * 3;
                if (count < 120)
                    totalprice = totalprice * 1.15;
                break;
            case "Gladiolus":

                totalprice = count * 2.5;
                if (count < 80)
                    totalprice = totalprice * 1.20;
                break;
            }

            if (budget < totalprice)
            {
                Console.WriteLine($"Not enough money, you need {(totalprice - budget):F2} leva more.");
            }
            else if (budget >= totalprice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {(budget - totalprice):F2} leva left.");

            }
        }
    }
}

            

