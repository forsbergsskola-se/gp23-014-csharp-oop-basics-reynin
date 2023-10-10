public class Player
{
    public int Level;
    public int Exp;

    public void GrantExperience()
    {
        Console.WriteLine("How much Exp. do you wish to gain?");
        this.Exp += int.Parse(Console.ReadLine());
        while (this.Exp >= 100)
        {
            Level++;
            this.Exp -= 100;
        }
        Console.WriteLine($"Lvl: {this.Level} Exp: {this.Exp}");
    }
}