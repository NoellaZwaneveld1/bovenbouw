using System;

namespace PokemonBattleSimulator
{
    class Program
    {
        // 1. The player starts the game.
        public void StartBattle()
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

            //4. The first trainer throws the first pokeball on its belt.
            // 5. The pokeball released the charmander and charmander does its battle cry.
            Console.WriteLine($"{trainer1.Name} throws their first Pokeball!");
            trainer1.ThrowPokeball(0);
            
            //6. The second trainer throws the first pokeball on its belt.
            



            //     //2. The player gives a name to a charmander.
            //     Console.WriteLine("Enter a nickname for Charmander: ");
            //     string nickName = Console.ReadLine();
            //
            //     Charmander charmander = new Charmander(nickName, "Fire", "Water");
            //     
            //     //3. The charmander does its battle cry for ten times.
            //     charmander.BattleCry();
            //
            //     while (true)
            //     {
            //         //4. The player can give a new name to the same charmander
            //         Console.WriteLine("Do you want to give your Charmander a new name? y/n/quit");
            //         string chooseNewName = Console.ReadLine();
            //
            //         if (chooseNewName == "y")
            //         {
            //             Console.WriteLine("Enter a new name for Charmander:");
            //             charmander.nickName = Console.ReadLine();
            //         }
            //         else if (chooseNewName == "n")
            //         {
            //             Console.WriteLine("That's alright! Your Charmander will keep its current nickname!");
            //         }
            //         else if (chooseNewName == "quit")
            //         {
            //             Console.WriteLine("Exiting game...");
            //             Environment.Exit(0);
            //         }
            //         else
            //         {
            //             Console.WriteLine("Invalid input. Please enter 'y', 'n', or 'quit'.");
            //             continue;
            //         }
            //
            //         charmander.BattleCry();
            //     }
            // }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.StartBattle();
        }
    }
}