class Shape
{
  protected double a_width;
  private double a_length;
  public Shape() => Width = Length = 0.0;
  public Shape(double w, double l)
  {
    Width = w;
    Length = l;
  }
  public Shape(double y) => Width = Length = y;
  public double Width
  {
    get
    {
      return a_width;
    }
    set
    {
      a_width = value < 0 ? -value : value;
    }
  }
  public double Length
  {
    get
    {
      return a_length;
    }
    set
    {
      a_length = value < 0 ? -value : value;
    }
  }
  public void displayDim() => System.Console.WriteLine($" Width and Length are {Width} and {Length}");
}

class Rectangle : Shape
{
  string Style;
  public Rectangle() => Style = "null";
  public Rectangle(string s, double w, double l) : base(w, l) => Style = s;

  public Rectangle(double y) : base(y) => Style = "square";

  public double Area()
  {
    return Width * Length;
  }
  public void DisplayStyle() => System.Console.WriteLine($"Rectangle is : {Style}");
}

class ColorRectangle : Rectangle
{
  string rColor;
  public ColorRectangle(string c, string s, double w, double l) : base(s, w, l)
  {
    rColor = c;
  }
  public void displayColor() => System.Console.WriteLine($"Color is : {rColor}");
}


