using System.Threading.Channels;

public class AblePick
{
    public bool IsAblePick = true;
}

public class Food : AblePick
{
    public bool IsEdible = true;
}

public class Bread : Food
{
    public string bread = "Bread";
}
public class Banana : Food
{
    public string banana = "Banana";
}
public class Apple : Food
{
    public string apple = "Apple";
}
public class Pear : Food
{
    public string pear = "pear";
}


public class Weapon
{
    public bool isWeapon = true;
}

public class Sword : Weapon
{
    
}
public class Axe : Weapon
{
    
}
public class Pencil : Weapon
{
    
}
public class Shield : Weapon
{
    
}
public class Spear : Weapon
{
    
}

public class Alive
{
    public bool IsAlive;
}

public class Tree
{
    
}
public class Gorilla : Alive
{
    
}
public class Chimpanzee : Alive
{
    
}
public class Sparrow : Alive
{
    
}
public class Pigeon : Alive
{
    
}
public class Hawk : Alive
{
    
}
