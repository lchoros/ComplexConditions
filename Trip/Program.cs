using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());

            string season = Console.ReadLine();
            string destinationResult = "Europe";
            string holidayInformation = "Hotel";
            decimal moneySpent = 0.00M;
            moneySpent = budget * 0.9M;

            if(budget <= 100)
            {
                destinationResult = "Bulgaria";
                if(season == "winter")
                {
                    moneySpent = budget * 0.7M;    
                }
                else
                {
                    holidayInformation = "Camp";
                    moneySpent = budget * 0.3M;
                }
             }
            else if(budget > 100 && budget <= 1000)
            {
                destinationResult = "Balkans";
                if (season == "winter")
                {
                    moneySpent = budget * 0.8M;
                }
                else
                {
                    holidayInformation = "Camp";               
                    moneySpent = budget * 0.4M;
                }
            }

            Console.WriteLine("Somewhere in {0}", destinationResult);
            Console.WriteLine("{0} - {1:F2}", holidayInformation, moneySpent);
        }
    }
}
