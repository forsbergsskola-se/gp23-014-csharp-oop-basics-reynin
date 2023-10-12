Knight attacker = new Knight();
Knight defender = new Knight();

Shield shield = new Shield();
Sword sword = new Sword();

defender.Defense = shield; // Defender equip shield

attacker.Attack(defender);
defender.GetHit(attacker.Offense); // attacker.Offense == null

Console.WriteLine("Equipping Sword...");
attacker.Offense = sword;

attacker.Attack(defender);
defender.GetHit(sword);
defender.Defense = null;

attacker.Attack(defender);
defender.GetHit(sword);