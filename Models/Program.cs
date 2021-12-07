using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Lets build triangles!");
      Console.WriteLine("---------------------");
      Console.WriteLine("Enter a number for side 1");
      int side1 =int.Parse(Console.ReadLine());

      Console.WriteLine("Enter a number for side 2");
      int side2 =int.Parse(Console.ReadLine());

      Console.WriteLine("Enter a number for side 3");
      int side3 =int.Parse(Console.ReadLine());

      Triangle yourTriangle = new Triangle();
      string output = yourTriangle.IsTriangle(side1, side2, side3);

      Console.WriteLine($"This your Triangle {output}" );

    }
  }
}