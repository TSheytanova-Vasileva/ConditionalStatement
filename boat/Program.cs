namespace boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countman = int.Parse(Console.ReadLine());
            double rentboat = 0;


            switch (season)
            {
                case "Spring":
                    rentboat = 3000;
                    if (countman <= 6 && countman % 2 == 0)
                        rentboat = rentboat * 0.9 * 0.95;
                   else if (countman <= 6)
                        rentboat = rentboat * 0.9;
                    else if (countman >= 7 && countman <= 11 && countman % 2 == 0)
                        rentboat = rentboat * 0.85*0.95;
                    else if (countman >= 7 && countman <= 11)
                        rentboat = rentboat * 0.85;
                    else if (countman >= 12 && countman % 2 == 0)
                        rentboat = rentboat * 0.75 * 0.95;
                    else if (countman >= 12)
                        rentboat = rentboat * 0.75;
                   
                    break;

                   
                case "Summer":
                    rentboat = 4200;
                    if (countman <= 6 && countman % 2 == 0)
                        rentboat = rentboat * 0.9 * 0.95;
                    else if ((countman <= 6))
                        rentboat = rentboat * 0.9;
                   else if (countman >= 7 && countman <= 11 && countman % 2 == 0)
                        rentboat = rentboat * 0.85* 0.95;
                    else if (countman >= 7 && countman <= 11)
                        rentboat = rentboat * 0.85;
                    else if (countman >= 12 && countman % 2 == 0)
                        rentboat = rentboat * 0.75;
                   else if (countman >= 12)
                        rentboat = rentboat * 0.75 *0.95;
                    break;

                case "Autumn":
                    rentboat = 4200;
                    if (countman <= 6)
                        rentboat = rentboat * 0.9;
                    if (countman >= 7 && countman <= 11)
                        rentboat = rentboat * 0.85;
                    if (countman >= 12)
                        rentboat = rentboat * 0.75;
                    break;

                case "Winter":
                    rentboat = 2600;
                    if (countman <= 6 && countman % 2 == 0)
                        rentboat = rentboat * 0.9 * 0.95;
                    if (countman <= 6)
                        rentboat = rentboat * 0.9;
                    if (countman >= 7 && countman <= 11 && countman % 2 == 0)
                        rentboat = rentboat * 0.85 * 0.95;
                    if (countman >= 7 && countman <= 11)
                        rentboat = rentboat * 0.85;
                    if (countman >= 12 && countman % 2 == 0)
                        rentboat = rentboat * 0.75* 0.95;
                    if (countman >= 12)
                        rentboat = rentboat * 0.75;
                    break;
            }
            if (budget >= rentboat)

                Console.WriteLine($"Yes! You have {(budget - rentboat):F2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {(rentboat - budget):F2} leva.");
        }



    }
}