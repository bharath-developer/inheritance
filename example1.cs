using System;

interface Iinter1
{
  void display();

}
class Example1 : Iinter1
{
  public void display()
  {
    Console.WriteLine("Welcome user");
  }
}
