using System;

namespace TriangleTracker.Models 
{
  public class Triangle
  {
    public string IsTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
      return "Equailateral";
      }
      else if (side1 == side2 || side3 == side2 || side1 == side3)
      {
      return "Isosceles";
      }
      else if (side1 != side2 && side2 != side3 && side1 != side3)
      {
        return "Scalene";
      }
      else
      {
        return "not a triangle";
      }
    }
  }
}

// create if (is equalateral)
// create else if (is isoscles)
// create else (is scalene)
