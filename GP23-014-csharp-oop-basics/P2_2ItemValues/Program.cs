Item [] bag = new Item[3];

for (int i = 0; i < 3; i++)
{
    bag[i].goldValue = 100 + i * 100;
    Console.WriteLine(bag[i].goldValue);
}


public class Item
{
    public int goldValue;
}