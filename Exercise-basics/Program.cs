Car c1 = new Car("Mazda", "Mx5", 1190);
c1.DisplayInfo();

class Car(String Brand, String Model, int ProductionDate)
{
   public void DisplayInfo()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " +  Model);
        Console.WriteLine("ProductionDate: "+  ProductionDate);
    }

    public string Brand { get; private set; } = Brand;
    public string Model { get; private set; } = Model;
    public int ProductionDate { get; private set; } = ProductionDate;

}