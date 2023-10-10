public class Player
{
    public int Level;
    public int Exp;
    public int levelUp = 100;
    public void GrantExperience(int expPlus)
    {
        this.Exp += expPlus;
        while (this.Exp >= levelUp)
        {
            Level++;
            this.Exp -= levelUp;
        }
        Console.WriteLine($"Lvl: {this.Level} Exp: {this.Exp}");
    }
}
