namespace clothe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());
            string timeofday = Console.ReadLine();
            string outfit = "";
            string shooes = "";

            if (degree >= 10 && degree <= 18)
            {
                if (timeofday == "Morning")
                {
                    outfit = "Sweatshirt";
                    shooes = "Sneakers";
                }
                else if (timeofday == "Afternoon" || timeofday == "Evening")
                {
                    outfit = "Shirt";
                    shooes = "Moccasins";
                }
            }
            if (degree > 18 && degree <= 24)
            {
                if (timeofday == "Morning")
                {
                    outfit = "Shirt";
                    shooes = "Moccasins";
                }
                else if (timeofday == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shooes = "Sandals";
                }
                else if (timeofday == "Evening")
                {
                    outfit = "Shirt";
                    shooes = "Moccasins";
                }
            }
            else if (degree >= 25)
            {
                if (timeofday == "Morning")
                {
                    outfit = "T-Shirt";
                    shooes = "Sandals";
                }
                else if (timeofday == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shooes = "Barefoot";
                }
                else if (timeofday == "Evening")
                {
                    outfit = "Shirt";
                    shooes = "Moccasins";
                }

            }
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shooes}.");
        }
    }
}