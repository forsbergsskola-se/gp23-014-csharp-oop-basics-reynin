public class Player
{
    public int health = 100;
    public int strength = 0;
     
    public void Eat(int valueHP)
    {
        this.health += valueHP;
    }

    public void PowerUp(int power)
    {
        this.strength += power;
    }

    public void attack(int target)
    {
        target -= strength;
    }
}