Item [] inventory = new Item[3];

for (int i = 0; i < 3; i++)
{
    inventory[i] = new Item();
    inventory[i].goldValue = 100 + i * 100;
    Console.WriteLine(inventory[i].goldValue);
}
