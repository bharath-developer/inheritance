class Vehicle
{
  public string brand = "Ford";
  public void honk() => System.Console.WriteLine("Tuur,tuur!");
}

class Car : Vehicle
{
  public string model { get; set; }
}
