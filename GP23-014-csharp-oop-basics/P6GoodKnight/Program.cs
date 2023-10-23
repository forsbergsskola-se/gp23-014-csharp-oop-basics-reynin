Knight attacker = new Knight();
Knight defender = new Knight();

Shield shield = new Shield();
Sword sword = new Sword();

defender.Defense = shield; // Defender equip shield

attacker.Attack(defender); // attacker.Offense == null

Console.WriteLine("Equipping Sword...");
attacker.Offense = sword; // Attacker now has a sword

attacker.Attack(defender); // Defenders shield breaks

attacker.Attack(defender); // Knight is wounded