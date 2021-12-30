using System;
namespace inheritance
{
  interface Ivehicle
  {
    void changeGear(int a);
    void speedUp(int a);
    void applyBreaks(int a);
  }

  class Bicycle : Ivehicle
  {
    public int gear { get; set; }
    public int speed { get; set; }
    public void changeGear(int newGear) => gear = newGear;
    public void speedUp(int increment) => speed = speed + increment;
    public void applyBreaks(int decrement) => speed = speed - decrement;
    public void printState() { Console.WriteLine($"speed : {speed} + gear : {gear}"); }
  }

  class Bike : Ivehicle
  {
    public int gear { get; set; }
    public int speed { get; set; }
    public void changeGear(int newGear) => gear = newGear;
    public void speedUp(int increment) => speed = speed + increment;
    public void applyBreaks(int decrement) => speed = speed - decrement;
    public void printState() { Console.WriteLine($"speed : {speed} + gear : {gear}"); }
  }

}