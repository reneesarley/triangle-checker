using System;
using System.Collections.Generic;

class Triangle
{
  private int _side1;
  private int _side2;
  private int _side3;

  public void AskSide()
  {
    Console.WriteLine("Length of side 1: ");
    string StringSide1 = Console.ReadLine();
    _side1 = int.Parse(StringSide1);
    Console.WriteLine("Length of side 2: ");
    string StringSide2 = Console.ReadLine();
    _side2 = int.Parse(StringSide2);
    Console.WriteLine("Length of side 3: ");
    string StringSide3 = Console.ReadLine();
    _side3 = int.Parse(StringSide3);
  }

  public bool TriangleCheck()
  {
    if (_side1 + _side2 < _side3 || _side1 + _side3 < _side2 || _side2 + _side3 < _side1)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool Equilateral()
  {
    if (_side1 == _side2 && _side1 == _side3 && _side2 == _side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool Isoceles()
  {
    if ((_side1 == _side2 || _side1 == _side3) && _side2 != _side3)
    {
      return true;
    }
    else if((_side2 == _side3 || _side2 == _side1) && _side3 != _side1)
    {
      return true;
    }
    else if((_side2 == _side3 || _side3 == _side1) && _side2 != _side1)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool Scalene()
  {
    if (_side1 != _side2 && _side1 != _side3 && _side2 != _side3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public int GetSide1()
  {
    return _side1;
  }

  public int GetSide2()
  {
    return _side2;
  }

  public int GetSide3()
  {
    return _side3;
  }
}

class Program
{
  public static void Main()
  {
    Triangle UserTriangle = new Triangle();
    UserTriangle.AskSide();
    if (UserTriangle.TriangleCheck())
    {
      Console.WriteLine("Sorry, not a valid triangle.");
    }
    else if (UserTriangle.Equilateral())
    {
      Console.WriteLine("You have an equilateral triangle!");
    }
    else if(UserTriangle.Isoceles())
    {
      Console.WriteLine("You have an Isoceles triangle.");
    }
    else if (UserTriangle.Scalene())
    {
      Console.WriteLine("You have a scalene triangle!");
    }
  }
}
