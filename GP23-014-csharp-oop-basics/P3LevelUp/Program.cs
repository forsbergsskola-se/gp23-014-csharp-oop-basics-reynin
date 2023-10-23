Player player = new Player();

while (true)
{
    Console.WriteLine("How much Exp. do you wish to gain?");
    player.GrantExperience(int.Parse(Console.ReadLine()));
    
    Console.WriteLine("Do you want to keep going? [yes] / [no]");
    string answer = Console.ReadLine();
    if (answer == "no")
    {
        break;
    }
}