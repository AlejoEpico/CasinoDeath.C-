using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPlayer = 0;
        int totalDealer = 0;
        int num = 0;
        int platziCoins = 0;
        string message = "";
        string takeAnotherCard = "";
        string switchControl = "menu";

        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Welcome to CasinoDeath");
            Console.WriteLine(
                "How many PlatziCoins do you want?\n"
                    + "Enter an integer number\n"
                    + "Remember you need 1 per round"
            );
            platziCoins = int.Parse(Console.ReadLine());

            for (int i = 0; i < platziCoins; i++)
            {
                totalPlayer = 0;
                totalDealer = 0;

                switch (switchControl)
                {
                    case "menu":
                        Console.WriteLine("Enter '21' to play 21");
                        switchControl = Console.ReadLine();
                        break;
                    case "21":
                        do
                        {
                            num = random.Next(1, 12);
                            totalPlayer += num;
                            Console.WriteLine("Take your card, player");
                            Console.WriteLine($"You got the number: {num}");
                            Console.WriteLine("Do you want another card?");
                            takeAnotherCard = Console.ReadLine();
                        } while (
                            takeAnotherCard.ToLower() == "yes" || takeAnotherCard.ToLower() == "y"
                        );

                        totalDealer = random.Next(14, 23);
                        Console.WriteLine($"The dealer has {totalDealer}");

                        if (totalPlayer > totalDealer && totalPlayer < 22)
                        {
                            message = "You beat the dealer, congratulations!";
                            switchControl = "menu";
                        }
                        else if (totalPlayer >= 22)
                        {
                            message = "You lost against the dealer, you went over 21";
                            switchControl = "menu";
                        }
                        else if (totalPlayer <= totalDealer)
                        {
                            message = "You lost against the dealer, sorry";
                            switchControl = "menu";
                        }
                        else
                        {
                            message = "Invalid condition";
                        }
                        Console.WriteLine(message);
                        break;
                    default:
                        Console.WriteLine("Invalid input at the CasinoDeath");
                        break;
                }
            }
        }
    }
}
