using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator
{
    public class Trainer
    {
        public string Name { get; private set; }
        private List<PokeBall> belt;

        // Constructor to initialize the trainer and fill the belt with 6 Pokémon (2 Charmander, 2 Squirtle, 2 Bulbasaur)
        public Trainer(string name)
        {
            Name = name;
            belt = new List<PokeBall>();

            // Add two Charmanders, two Squirtles, and two Bulbasaurs to the trainer's belt
            for (int i = 1; i <= 2; i++)
            {
                Charmander charmander = new Charmander($"Charmander{i}");
                PokeBall pokeball = new PokeBall(Name); // ✅ Pass trainer's name
                pokeball.Capture(charmander);
                belt.Add(pokeball);
            }

            for (int i = 1; i <= 2; i++)
            {
                Squirtle squirtle = new Squirtle($"Squirtle{i}");
                PokeBall pokeball = new PokeBall(Name);
                pokeball.Capture(squirtle);
                belt.Add(pokeball);
            }

            for (int i = 1; i <= 2; i++)
            {
                Bulbasaur bulbasaur = new Bulbasaur($"Bulbasaur{i}");
                PokeBall pokeball = new PokeBall(Name);
                pokeball.Capture(bulbasaur);
                belt.Add(pokeball);
            }
        }

        // Throw a Pokeball to release a Pokémon at the given index
        public void ThrowPokeball(int index)
        {
            if (index < 0 || index >= belt.Count)
            {
                Console.WriteLine("Invalid Pokeball index!");
                return;
            }
            belt[index].Throw(); // Call Throw on the selected Pokeball
        }

        // Return the Pokémon to its Pokeball
        public void ReturnPokemon(int index)
        {
            if (index < 0 || index >= belt.Count)
            {
                Console.WriteLine("Invalid Pokeball index!");
                return;
            }
            belt[index].ReturnPokemon(); // Call Return to put the Pokémon back
        }
    }
}