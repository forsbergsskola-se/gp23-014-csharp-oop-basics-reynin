using System.Drawing;

House little = new House();
little.color = "Turquoise";
little.stories = 2;
House big = new House();
big.color = "Yellow";
big.stories = 3;

Circle circle = new Circle();
circle.roundThing[0] = "Green";
circle.roundThing[1] = "Yellow";
circle.roundThing[2] = "Blue";
circle.roundThing[3] = "Red";

People people = new People();
people.Marc = 100;
people.Alex = 12;
people.Felix = 5;
public class People
{
    public int Marc;
    public int Alex;
    public int Felix;
}

public class Car
{
    public int seats;
    public int speed;
}

public class House
{
    public int stories;
    public string color;
}


public class Circle
{
    public string[] roundThing = new string[4];
}