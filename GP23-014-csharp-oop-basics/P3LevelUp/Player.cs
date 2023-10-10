public class Player
{
    public int Level;
    public int Exp;

    public void GrantExperience(int expPlus)
    {
        this.Exp += expPlus;
        while (this.Exp >= 100)
        {
            Level++;
            this.Exp -= 100;
        }
        Console.WriteLine($"Lvl: {this.Level} Exp: {this.Exp}");
    }
}
