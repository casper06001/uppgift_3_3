using System;

class Program
{
    static void Main()
    {
        const int hourlyRate = 80;
        const int maxDailyCost = 950;

        Console.Write("Hur många timmar vill du hyra en bil: ");
        int hours = int.Parse(Console.ReadLine());

        if (hours <= 0)
        {
            Console.WriteLine("Felaktigt antal timmar. Ange minst 1 timme.");
        }
        else if (hours > 24)
        {
            Console.WriteLine("Du kan inte hyra en bil i mer än 24 timmar.");
        }
        else
        {
            int cost = Math.Min(hours * hourlyRate, maxDailyCost);
            Console.WriteLine("Kostnaden för att hyra en bil i {0} timmar är {1} kronor.", hours, cost);
        }
    }
}
