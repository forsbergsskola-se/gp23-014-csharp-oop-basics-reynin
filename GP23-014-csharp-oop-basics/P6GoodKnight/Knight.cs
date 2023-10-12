public class Knight
{
    public Shield Defense;
    public Sword Offense;
    
    public void GetHit(Sword x)
    {
        if (x == null)
        {
            Console.WriteLine("Knights Shield fends off the strike.");
        }
        else if (x != null && Defense != null)
        {
            Console.WriteLine("Knights Shield was pierced by the Sword.");
            this.Defense = null;
        }
        else
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
        
    }

    public void Attack(Knight y)
    {
        if (Offense == null)
        {
            Console.WriteLine("Knight attacks Knight with Bare Hands.");
        }
        else
        {
            Console.WriteLine("Knight attacks Knight with a Sword.");
        }
    }
}