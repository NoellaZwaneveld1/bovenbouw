using System;

namespace PokemonBattleSimulator
{
    class Program
    {
        // 1. The player starts the game.
        public void StartBattle()
        {
            while (true)
            {
                Console.WriteLine("Hello player, Do you want to start the Battle? y/n");
                string startGame = Console.ReadLine();

                if (startGame == "y")
                {
                    Console.WriteLine("The battle begins!");
                }
                else if (startGame == "n")
                {
                    Console.WriteLine("Exiting game...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    return;
                }

                // 2. The player gives a name to the first trainer
                Console.WriteLine("Enter a name for trainer 1: ");
                string trainer1Name = Console.ReadLine();

                Trainer trainer1 = new Trainer(trainer1Name);

                //3. The player gives a name to the second trainer.
                Console.WriteLine("Enter a name for trainer 2: ");
                string trainer2Name = Console.ReadLine();

                Trainer trainer2 = new Trainer(trainer2Name);
                
                //10. Repeat 4 to 9 until all pokeballs have been used by both trainers.
                int round = 0;
                while (round < 6)
                {
                    //4. The first trainer throws the first pokeball on its belt.
                    // 5. The pokeball released the charmander and charmander does its battle cry.
                    trainer1.ThrowPokeball(index: round);

                    //6. The second trainer throws the first pokeball on its belt.
                    //7. The pokeball released the charmander and charmander does its battle cry.
                    trainer2.ThrowPokeball(index: round);

                    //8. The first trainer returns the charmander back to its pokeball.
                    trainer1.ReturnPokemon(index: round);

                    //9. The second trainer returns the charmander back to its pokeball.
                    trainer2.ReturnPokemon(index: round);

                    round++;
                    
                    if (round == 6)
                    {
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Do you want to continue (c), restart (r) or quit (q) the game? ");
                    string choice = Console.ReadLine();
                    
                    if (choice == "r")
                    {
                        Console.WriteLine("Restarting game...");
                        Console.Clear(); // Clears the console for a fresh restart
                        break;
                    }
                    else if (choice == "q")
                    {
                        Console.WriteLine("Quitting game...");
                        Environment.Exit(0);
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.StartBattle();
        }
    }
}