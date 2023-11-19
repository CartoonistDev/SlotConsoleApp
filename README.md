# Slot Machine Console App

Welcome to the Slot Machine Console App! This application simulates a simple slot machine game where users can make deposits, spin the slot machine, and try their luck to win.

## Getting Started

To run the application, make sure you have the .NET SDK installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/CartoonistDev/SlotMachineConsoleApp.git

2. Navigate to the project directory:

    ```bash    
    cd SlotMachineConsoleApp
3. Run the application:
    ```bash
    dotnet run

## Usage
When prompted, enter your initial deposit amount to start the game.

Enter the amount you want to stake for each spin. You can enter 0 to exit the game.

The result of each spin, win amount, and total balance will be displayed.

The game continues until your balance reaches zero or you choose to exit by entering 0.

### Project Structure

SlotMachine.cs: Contains the SlotMachine class, which encapsulates the game logic.
ISlotSymbol.cs: Defines the ISlotSymbol interface for slot symbols.
Apple.cs, Banana.cs, Pineapple.cs, Wildcard.cs: Classes representing individual slot symbols.


### Contributing
If you would like to contribute to the project, please follow these steps:

### Fork the repository.
Create a new branch for your feature or bug fix.
Make your changes and commit them.
Push your changes to your fork.
Open a pull request, explaining your changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


### Acknowledgments
This project is inspired by simple slot machine games.
Happy Spinning!
