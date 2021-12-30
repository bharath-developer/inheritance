using System;
namespace Inherit
{
  class Program
  {
    public string name;
    public string subject;
    public void readers(string Name, string Subject)
    {
      this.name = Name;
      this.subject = Subject;
      Console.WriteLine($"Myself : {name}");
      Console.WriteLine($"My favourite subject is  : {subject}");
    }
  }

  class GetData : Program
  {
    public GetData()
    {
      Console.WriteLine("Constuctor First prints this line");
    }
  }
}