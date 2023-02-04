namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
            string Paper = @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
";
            string Scissors = @"
_______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";



            int PlayerWins = 0;
            int ComputerWins = 0;
            bool GameStart = true;
            do
            {
                Console.WriteLine($"------------------------------\nPlayer Wins : {PlayerWins} | Computer : {ComputerWins}\n ----------------------------- ");
                Console.WriteLine("What would you like to throw? \n1) Rock\n2) Paper\n3) Scissors");
                int input = Convert.ToInt32(Console.ReadLine());
                int ComputerInput = new Random().Next();

                Console.WriteLine("PLAYER");
                if (input == 1)
                {
                    Console.WriteLine($"{Rock}");
                }
                else if (input == 2)
                {
                    Console.WriteLine($"{Paper}");
                }
                else if (input == 3)
                {
                    Console.WriteLine($"{Scissors}");
                }
                else
                {
                    break;
                }
                Console.WriteLine("VS");

                Console.WriteLine("COMPUTER");
                if (ComputerInput == 1)
                {
                    Console.WriteLine($"{Rock}");
                }
                else if (ComputerInput == 2)
                {
                    Console.WriteLine($"{Paper}");
                }
                else if (ComputerInput == 3)
                {
                    Console.WriteLine($"{Scissors}");
                }
                else
                {
                    break;
                }


                if (input == 1 && ComputerInput == 3 || input == 2 && ComputerInput == 1 || input == 3 && ComputerInput == 2)
                {
                    PlayerWins += 1;
                }
                else if (ComputerInput == 1 && input == 3 || ComputerInput == 2 && input == 1 || ComputerInput == 3 && input == 2)
                {
                    ComputerWins += 1;
                }
                else
                {
                    Console.WriteLine("DRAW");
                }

                Console.ReadKey();
                Console.Clear();

                if (PlayerWins == 3)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("\r\n /$$     /$$ /$$$$$$  /$$   /$$       /$$      /$$ /$$$$$$ /$$   /$$\r\n|  $$   /$$//$$__  $$| $$  | $$      | $$  /$ | $$|_  $$_/| $$$ | $$\r\n \\  $$ /$$/| $$  \\ $$| $$  | $$      | $$ /$$$| $$  | $$  | $$$$| $$\r\n  \\  $$$$/ | $$  | $$| $$  | $$      | $$/$$ $$ $$  | $$  | $$ $$ $$\r\n   \\  $$/  | $$  | $$| $$  | $$      | $$$$_  $$$$  | $$  | $$  $$$$\r\n    | $$   | $$  | $$| $$  | $$      | $$$/ \\  $$$  | $$  | $$\\  $$$\r\n    | $$   |  $$$$$$/|  $$$$$$/      | $$/   \\  $$ /$$$$$$| $$ \\  $$\r\n    |__/    \\______/  \\______/       |__/     \\__/|______/|__/  \\__/\r\n                                                                    \r\n                                                                    \r\n                                                                    \r\n");
                    break;
                }
                else if (ComputerWins == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\n /$$     /$$ /$$$$$$  /$$   /$$       /$$        /$$$$$$   /$$$$$$  /$$$$$$$$\r\n|  $$   /$$//$$__  $$| $$  | $$      | $$       /$$__  $$ /$$__  $$| $$_____/\r\n \\  $$ /$$/| $$  \\ $$| $$  | $$      | $$      | $$  \\ $$| $$  \\__/| $$      \r\n  \\  $$$$/ | $$  | $$| $$  | $$      | $$      | $$  | $$|  $$$$$$ | $$$$$   \r\n   \\  $$/  | $$  | $$| $$  | $$      | $$      | $$  | $$ \\____  $$| $$__/   \r\n    | $$   | $$  | $$| $$  | $$      | $$      | $$  | $$ /$$  \\ $$| $$      \r\n    | $$   |  $$$$$$/|  $$$$$$/      | $$$$$$$$|  $$$$$$/|  $$$$$$/| $$$$$$$$\r\n    |__/    \\______/  \\______/       |________/ \\______/  \\______/ |________/\r\n                                                                             \r\n                                                                             \r\n                                                                             \r\n");
                    break;
                }

            } while (GameStart == true);
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}
