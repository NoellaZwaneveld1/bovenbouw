namespace PokemonBattleSimulator;

public class Charmander
{
    public string nickName;
    public string strength;
    public string weakness;

    public Charmander(string nickName, string strength, string weakness)
    {
        this.nickName = nickName;
        this.strength = strength;
        this.weakness = weakness;
    }

    public void BattleCry()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"!{nickName}!");
        }
    }
}