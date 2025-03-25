using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator;

public class Trainer
{
    public string Name { get; private set; }
    private List<PokeBall> belt;

    public Trainer(string name)
    {
        Name = name;
        belt = new List<PokeBall>();
        
        // Fill the belt with 6 Pokeballs, each containing a Charmander
        for (int i = 1; i <= 6; i++)
        {
            Charmander charmander = new Charmander($"Charmander{i}", "Fire", "Water");
            PokeBall pokeball = new PokeBall(Name); // ✅ FIX: Pass trainer's name
            pokeball.Capture(charmander);
            belt.Add(pokeball);
        }
    }

    public void ThrowPokeball(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid Pokeball index!");
            return;
        }

        belt[index].Throw(); // Trainer's name will now be used in PokeBall
    }

    public void ReturnPokemon(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid Pokeball index!");
            return;
        }

        belt[index].ReturnCharmander();
    }
}