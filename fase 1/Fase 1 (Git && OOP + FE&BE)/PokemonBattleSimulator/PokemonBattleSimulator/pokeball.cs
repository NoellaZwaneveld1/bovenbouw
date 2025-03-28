using System;

namespace PokemonBattleSimulator
{
    public class PokeBall
    {
        private Pokemon containedPokemon;
        private bool isOpen;
        private string trainerName; // Stores trainer's name

        public PokeBall(string trainerName) // ✅ Ensure constructor accepts name
        {
            this.trainerName = trainerName;
            this.isOpen = false;
        }

        // Capture any type of Pokemon (not just Charmander)
        public void Capture(Pokemon pokemon)
        {
            if (containedPokemon == null)
            {
                containedPokemon = pokemon;
                // Console.WriteLine($"{trainerName} captured {pokemon.Nickname} in a Pokeball!");
            }
            else
            {
                Console.WriteLine("The Pokeball already contains a Pokémon!");
            }
        }

        // Throw the Pokeball to release the Pokémon
        public void Throw()
        {
            if (containedPokemon != null && !isOpen)
            {
                isOpen = true;
                Console.WriteLine($"{trainerName} threw the Pokeball! {containedPokemon.Nickname} has been released!");
                containedPokemon.BattleCry(); // Pokémon performs a battle cry upon release
            }
            else
            {
                Console.WriteLine($"{trainerName} threw an empty or already open Pokeball!");
            }
        }

        // Return the Pokémon to the Pokeball (this method should not take parameters)
        public void ReturnPokemon()
        {
            if (containedPokemon != null && isOpen)
            {
                isOpen = false;
                Console.WriteLine($"{trainerName} called {containedPokemon.Nickname} back into the Pokeball!");
            }
            else
            {
                Console.WriteLine($"{trainerName} has no Pokémon to return.");
            }
        }
    }    
}
