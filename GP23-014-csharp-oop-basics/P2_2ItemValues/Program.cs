Item [] inventory = new Item[3];

for (int itemIndex = 0; itemIndex < inventory.Length; itemIndex++)
{
    inventory[itemIndex] = new Item();
    inventory[itemIndex].goldValue = 100 + itemIndex * 100;
    Console.WriteLine(inventory[itemIndex].goldValue);
}
