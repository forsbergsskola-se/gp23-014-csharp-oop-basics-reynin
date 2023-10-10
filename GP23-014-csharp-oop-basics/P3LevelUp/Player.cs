public class Player
{
    public int Level;
    public int Exp;

    public void GrantExperience()
    {
        Console.WriteLine("How much Exp. do you wish to gain?");
        Exp += int.Parse(Console.ReadLine());
        while (Exp >= 100)
        {
            Level++;
            Exp -= 100;
        }
        Console.WriteLine($"Lvl: {Level} Exp: {Exp}");
    }
}