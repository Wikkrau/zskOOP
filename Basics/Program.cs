
Desk d1 = new Desk("green", "Auchan");

Console.WriteLine(d1.height);


while(true)
{
    d1.Lift();
    Thread.Sleep(500);
}


class Desk(string colour, string brand)
{
    public const decimal MAX_HEIGHT = 2.0m;
    public decimal height { get; private set; } = 1.0m;
    public string colour { get; private set; } = colour;
    public string brand { get; private set; } = brand;

    //Constructor (style 1)
    //public Desk(int height, string colour, string brand)
    //{
    //    this.height = height;
    //    this.colour = colour;
    //    this.brand = brand;
    //}

    public decimal getHeight()
    {
        return height;
    }
    public void Lift()
    {
        if (height < MAX_HEIGHT)
        {
            height += 0.1m;
        } else
        {
            Console.WriteLine($"Hey, it's too high. Max {MAX_HEIGHT}");
        }
        Console.WriteLine($"Desk is on {height} height");
    }
}


// public, private, protected

