Player player = new Player();

while (true)
{
    player.GrantExperience();
    
    Console.WriteLine("Do you want to keep going? [yes] / [no]");
    string answer = Console.ReadLine();
    if (answer == "no")
    {
        break;
    }
}