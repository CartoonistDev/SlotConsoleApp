using SlotConsoleApp;

class Program
{
    static void Main()
    {
        SlotMachine slotMachine = new();
        slotMachine.Initialize();

        while (slotMachine.Balance > 0)
        {
            int stake;
            // Continue prompting the user for a valid stake until a positive integer is entered

            do
            {
                Console.Write("Enter the amount you want to stake (enter 0 to exit): ");

                // Try to parse the user input into an integer
                // If parsing fails or the entered value is not positive, display an error message
                if (!int.TryParse(Console.ReadLine(), out stake) || stake < 0)
                {
                    Console.WriteLine("Invalid stake amount. Please enter a positive integer for the stake (enter 0 to exit).");
                }
            } while (stake <= 0);

            if (stake == 0)
            {       
                // If the user entered 0, exit the loop and end the game
                Console.WriteLine("Exiting the game. Thank you for playing!");
                break;
            }

            // Proceed with the spin using the valid stake
            slotMachine.Spin(stake);
        }

    }
}
