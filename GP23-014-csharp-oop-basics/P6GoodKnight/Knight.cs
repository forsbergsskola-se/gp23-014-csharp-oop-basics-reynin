public class Knight
{
    public Shield Defense;
    public Sword Offense;
    
    public void GetHit(Sword target)
    {
        if (target == null)
        {
            Console.WriteLine("Knights Shield fends off the strike.");
        }
        else if (target != null && this.Defense != null)
        {
            Console.WriteLine("Knights Shield was pierced by the Sword.");
            this.Defense = null;
        }
        else
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
        
    }

    public void Attack(Knight target)
    {
        if (Offense == null)
        {
            Console.WriteLine("Knight attacks Knight with Bare Hands.");
        }
        else if (this.Offense != null)
        {
            Console.WriteLine("Knight attacks Knight with a Sword.");
        }
        target.GetHit(this.Offense);
    }
}