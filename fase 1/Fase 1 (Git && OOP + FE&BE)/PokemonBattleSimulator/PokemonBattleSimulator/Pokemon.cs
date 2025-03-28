using System;

namespace PokemonBattleSimulator
{
    public abstract class Pokemon // Make Pokemon class public
    {
        public string Nickname;
        public string Strength;
        public string Weakness;

        // Constructor for all Pokemon
        public Pokemon(string nickname, string strength, string weakness)
        {
            this.Nickname = nickname;
            this.Strength = strength;
            this.Weakness = weakness;
        }

        // Abstract method to be implemented by subclasses
        public abstract void BattleCry();
    }

    // Charmander subclass
    public class Charmander : Pokemon
    {
        public Charmander(string nickname) : base(nickname, "Fire", "Water")
        {
        }

        public override void BattleCry()
        {
            // Charmander's battle cry
            Console.WriteLine($"{Nickname} shouts: Char! Charmander!");
        }
    }

    // Squirtle subclass
    public class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base(nickname, "Water", "Leaf")
        {
        }

        public override void BattleCry()
        {
            // Squirtle's battle cry
            Console.WriteLine($"{Nickname} shouts: Squirtle! Squirtle!");
        }
    }

    // Bulbasaur subclass
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base(nickname, "Grass", "Fire")
        {
        }

        public override void BattleCry()
        {
            // Bulbasaur's battle cry
            Console.WriteLine($"{Nickname} shouts: Bulba! Bulbasaur!");
        }
    }
}