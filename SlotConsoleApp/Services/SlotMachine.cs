namespace SlotConsoleApp
{
    public class SlotMachine
    {
        private readonly ISlotSymbol[,] grid;
        private readonly Random random;

        public SlotMachine()
        {
            grid = new ISlotSymbol[4, 3];
            random = new Random();
        }

        public int Deposit { get; private set; }
        public int Balance { get; private set; }

        // Method to initialize the slot machine
        public void Initialize()
        {
            Console.WriteLine("Welcome to the Slot Machine Game!");
           
            // Continue prompting the user for a valid deposit until a non-negative integer is provided

            while (true)
            {
                Console.Write("Enter your initial deposit amount: ");

                // Try to parse the user input into an integer
                // If parsing succeeds and the entered value is non-negative, set Deposit and Balance
                if (int.TryParse(Console.ReadLine(), out int inputDeposit) && inputDeposit >= 0)
                {
                    Deposit = inputDeposit;
                    Balance = Deposit;
                    break; // Exit the loop if a valid input is provided
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                }
            }
        }
        public void Spin(int stake)
        {
            if (stake > Balance)
            {
                Console.WriteLine("Insufficient balance. Please enter a valid stake amount.");
                return;
            }

            // Generate the slot grid for the spin
            GenerateSlotGrid();

            // Display the result of the spin
            DisplaySlotGrid();

            // Calculate and display the win amount and update the balance
            int winAmount = CalculateWinAmount(stake);

            Balance = Balance - stake + winAmount;

            Console.WriteLine($"Win amount: {winAmount}");
            Console.WriteLine($"Total balance: {Balance}");

            if (Balance == 0)
            {
                Console.WriteLine("Game Over! Your balance is zero.");
            }
        }

        private void GenerateSlotGrid()
        {
            ISlotSymbol[] symbols = { new Apple(), new Banana(), new Pineapple(), new Wildcard() };
            double[] probabilities = { 0.45, 0.35, 0.15, 0.05 };

            // Populate each cell in the grid with a randomly chosen symbol based on probabilities
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    double rand = random.NextDouble();
                    double cumulativeProbability = 0;

                    // Choose a symbol based on the random number and probabilities
                    for (int i = 0; i < symbols.Length; i++)
                    {
                        cumulativeProbability += probabilities[i];

                        if (rand < cumulativeProbability)
                        {
                            grid[row, col] = symbols[i];
                            break;
                        }
                    }
                }
            }
        }

        private void DisplaySlotGrid()
        {
            Console.WriteLine("Slot Machine Result:");

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(grid[row, col].Display() + " ");
                }
                Console.WriteLine();
            }
        }

        private int CalculateWinAmount(int stake)
        {
            int winAmount = 0;

            for (int row = 0; row < 4; row++)
            {
                if (grid[row, 0] == grid[row, 1] && grid[row, 1] == grid[row, 2])
                {
                    // If the first cell is a Wildcard, use the coefficient of the second cell
                    if (grid[row, 0] is Wildcard)
                    {
                        winAmount += (int)(grid[row, 1].Coefficient * stake);
                    }
                    // Otherwise, use the coefficient of the first cell
                    else
                    {
                        winAmount += (int)(grid[row, 0].Coefficient * stake);
                    }
                }
            }

            return winAmount;
        }    
    }
}
