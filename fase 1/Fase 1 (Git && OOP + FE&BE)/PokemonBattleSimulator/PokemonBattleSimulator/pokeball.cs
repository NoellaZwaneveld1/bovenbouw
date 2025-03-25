using System;

namespace PokemonBattleSimulator;

public class PokeBall
{
    private Charmander containedCharmander;
    private bool isOpen;
    private string trainerName; // Stores trainer's name

    public PokeBall(string trainerName) // ✅ Ensure constructor accepts name
    {
        this.trainerName = trainerName;
        this.isOpen = false;
    }

    public void Capture(Charmander charmander)
    {
        if (containedCharmander == null)
        {
            containedCharmander = charmander;
            //Console.WriteLine($"{trainerName} captured {charmander.nickName} in a Pokeball!");
        }
        else
        {
            Console.WriteLine("The Pokeball already contains a Pokémon!");
        }
    }

    public void Throw()
    {
        if (containedCharmander != null && !isOpen)
        {
            isOpen = true;
            Console.WriteLine($"{trainerName} threw the Pokeball! {containedCharmander.nickName} has been released!");
        }
        else
        {
            Console.WriteLine($"{trainerName} threw an empty or already open Pokeball!");
        }
    }

    public void ReturnCharmander()
    {
        if (containedCharmander != null && isOpen)
        {
            isOpen = false;
            Console.WriteLine($"{trainerName} called {containedCharmander.nickName} back into the Pokeball!");
        }
        else
        {
            Console.WriteLine($"{trainerName} has no Pokémon to return.");
        }
    }
}