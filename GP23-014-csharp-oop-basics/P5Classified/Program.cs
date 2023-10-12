using Microsoft.VisualBasic;

Player player = new Player();

Bread bread = new Bread();
Banana banana = new Banana();
Apple apple = new Apple();
Pear pear = new Pear();

Sword sword = new Sword();
Axe axe = new Axe();
Pencil pencil = new Pencil();
Shield shield = new Shield();
Spear spear = new Spear();

Gorilla gorilla = new Gorilla();
Chimpanzee chimpanzee = new Chimpanzee();
Sparrow sparrow = new Sparrow();
Pigeon pigeon = new Pigeon();
Hawk hawk = new Hawk();
Tree tree = new Tree();

player.Eat(bread.valueHP); //Example: Player gains HP by eating bread
player.PowerUp(sword.valueStrength); // Example: Player gains STRENGTH by gaining a weapon 
player.attack(gorilla.health); // Example: Player attacks by decreasing targets HEALTH with players STRENGTH


public class Food : Player
{
    public bool IsEdible = true;
}

public class Bread : Food
{
    public int valueHP = 20;
}
public class Banana : Food
{
    public int valueHP = 15;
}
public class Apple : Food
{
    public int valueHP = 10;

}
public class Pear : Food
{
    public int valueHP = 10;
}

public class Weapon : Player
{
    public bool isWeapon = true;
}

public class Sword : Weapon
{
    public int valueStrength = 30;
}
public class Axe : Weapon
{
    public int valueStrength = 35;

}
public class Pencil : Weapon
{
    public int valueStrength = 1;

}
public class Shield : Weapon // Add defence points instead?
{
    public int valueStrength = 5;

}
public class Spear : Weapon
{
    public int valueStrength = 25;
}


public class Object
{
    public bool Interactable;
}


public class Tree : Object
{
    public int health = 1000;
}

public class Gorilla : Object
{
    public int health = 100;
}

public class Chimpanzee : Object
{
    public int health = 80;
}
public class Sparrow : Object
{
    public int health = 40;

}
public class Pigeon : Object
{
    public int health = 10;

}
public class Hawk : Object
{
    public int health = 50;
}
}