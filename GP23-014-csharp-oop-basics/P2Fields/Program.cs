Information player = new Information();

player.Gold = 200;
player.Stone = 110;
player.Wood = 53;
player.level = 12;
player.Exp = 123;
player.VIP = true;
player.PvP = false;
player.Name = "Marc";
player.email = "marc@zaku.de";

Console.WriteLine($"Gold: {player.Gold}\nStone: {player.Stone}\nWood: {player.Wood}\nLevel: {player.level}\nExp: {player.Exp}");
Console.WriteLine(player.VIP ? "VIP Subscriber" : "VIP disabled");
Console.WriteLine(player.PvP ? "PvP Able" : "PvP disabled");
Console.WriteLine($"Player information: {player.Name}\nE-Mail: {player.email}");

