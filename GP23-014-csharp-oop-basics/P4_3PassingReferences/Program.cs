void Sell(House x)
{
    x.Owner = "Alex";
}

House house = new House();

house.PrintOwner();
Sell(house);
house.PrintOwner();