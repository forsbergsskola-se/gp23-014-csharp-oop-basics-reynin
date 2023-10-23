Player player1 = new Player();
Player player2 = new Player();

void PlayerVsPlayer(Player attacking, Player defending)
{
    attacking.Attack(defending);
    Console.WriteLine($"Player 1 Damage: {player1.Damage}");
    Console.WriteLine($"Player 2 Damage: {player2.Damage}");
}

Console.WriteLine("Player 1 attacks Player 2");
PlayerVsPlayer(player1,player2);

Console.WriteLine("Player 2 attacks Player 1");
PlayerVsPlayer(player2,player1);

Console.WriteLine("Player 1 attacks Player 1");
PlayerVsPlayer(player1,player1);

Player player3 = player1;

Console.WriteLine("Player 2 attacks Player 3");
PlayerVsPlayer(player2, player3);
Console.WriteLine($"Player 3 Damage: {player3.Damage}");