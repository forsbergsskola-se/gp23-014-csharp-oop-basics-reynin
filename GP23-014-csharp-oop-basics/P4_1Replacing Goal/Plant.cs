public class Plant
{
    public bool isGrown;
    public void PrintStatus()
    {
        Console.WriteLine(!isGrown ? "Plant is a seed." : "Plant is a tree.");
    }

    public void Grow()
    {
        if (!isGrown)
        {
            Console.WriteLine("Plany is growing.");
            isGrown = true;
        }
        else
            Console.WriteLine("Plant has already grown.");
    }

}