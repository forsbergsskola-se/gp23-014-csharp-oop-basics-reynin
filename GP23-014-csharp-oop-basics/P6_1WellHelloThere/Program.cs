ObiWan jedi = new ObiWan();
Console.WriteLine(jedi);
Console.WriteLine(jedi.Weapon);
Lightsaber blade = new Lightsaber();
jedi.Weapon = blade;
Console.WriteLine(jedi.Weapon);