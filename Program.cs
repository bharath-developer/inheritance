using System;
using inheritance;
using Inherit;
using Family;

namespace interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      int choice;
      Console.WriteLine("\n");
      Console.WriteLine("Choices");
      Console.WriteLine("1 - example 1");
      Console.WriteLine("2 - example 2");
      Console.WriteLine("3 - Simple inheritance");
      Console.WriteLine("4 - MultiLevel inheritance");
      Console.WriteLine("5 - Inheritance Base Derived");
      Console.WriteLine("6 - Inheritance Family");
      Console.Write("Enter your choice : ");
      choice = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("\n");
      switch (choice)
      {
        case 1:
          Example1 obj = new Example1();
          obj.display();
          break;
        case 2:
          Bicycle cycle = new Bicycle();
          cycle.speed = 50;
          cycle.gear = 3;
          cycle.speedUp(50);
          cycle.applyBreaks(10);
          cycle.changeGear(2);
          Console.WriteLine("Bicycle present state :");
          cycle.printState();
          Bike bike = new Bike();
          bike.speed = 70;
          bike.gear = 3;
          bike.speedUp(50);
          bike.applyBreaks(30);
          bike.changeGear(2);
          Console.WriteLine("Bike present state :");
          bike.printState();
          break;
        case 3:
          Car mustang = new Car();
          mustang.honk();
          mustang.model = Console.ReadLine();
          Console.WriteLine($"{mustang.brand} {mustang.model}");
          break;
        case 4:
          ColorRectangle rec1 = new ColorRectangle("Blue", "Wide Rectangle", 4.30, 6.054);
          ColorRectangle rec2 = new ColorRectangle("Green", "Curly Yellow", 4.51, 9.630);
          Console.WriteLine("Details of rec1");
          rec1.DisplayStyle();
          rec1.displayDim();
          rec1.displayColor();
          Console.WriteLine("Area is " + rec1.Area());
          Console.WriteLine("Details of rec2");
          rec2.DisplayStyle();
          rec2.displayDim();
          rec2.displayColor();
          Console.WriteLine("Area is " + rec2.Area());
          break;
        case 5:
          string name, fav;
          Console.WriteLine("Enter the name :");
          name = Console.ReadLine();
          Console.WriteLine("Enter the fav subject :");
          fav = Console.ReadLine();
          GetData print = new GetData();
          print.readers(name, fav);
          break;
        case 6:
          childFirst f1 = new childFirst();
          Console.WriteLine($"My name is {f1.ChildDName()}.My first name is {f1.fatherName()}");
          childSecond f2 = new childSecond();
          Console.WriteLine($"My name is {f2.ChildDName()}.My first name is {f2.fatherName()}");
          break;
        default:
          Console.WriteLine("Enter correct choice.");
          break;
      }

      Console.WriteLine("");
    }
  }
}
