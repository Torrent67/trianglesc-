using System;

class Triangle
{
  public bool Equilateral;
  public bool Isosceles;
  public bool Scalene;
  public bool NotTriangle;
  public int Side1;
  public int Side2;
  public int Side3;

  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
    Equilateral = false;
    Isosceles = false;
    Scalene = false;
    NotTriangle = false;
  }

  public void checkTriangle(int number1, int number2, int number3)
  {
    if (number1 + number2 <= number3 || number2 + number3 <= number1 || number3 + number1 <= number2)
    {
      NotTriangle = true;
    }
    else if (number1 == number2 && number2 == number3)
    {
      Equilateral = true;
    }
    else if (number1 == number2 || number2 == number3 || number1 == number3)
    {
      Isosceles = true;
    }
    else
    {
      Scalene = true;
    }
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter first number: ");
    string stringNumber1 = Console.ReadLine();
    int number1 = int.Parse(stringNumber1);

    Console.WriteLine("Enter second number: ");
    string stringNumber2 = Console.ReadLine();
    int number2 = int.Parse(stringNumber2);

    Console.WriteLine("Enter third number: ");
    string stringNumber3 = Console.ReadLine();
    int number3 = int.Parse(stringNumber3);

    Triangle newTriangle = new Triangle (number1, number2, number3);
    newTriangle.checkTriangle(number1, number2, number3);

    if (newTriangle.NotTriangle)
    {
      Console.WriteLine("Not a Triangle!!!!!!!!!!!!!!!!!!");
    }
    else if (newTriangle.Equilateral)
    {
      Console.WriteLine("Equilateral Triangle!");
    }
    else if (newTriangle.Isosceles)
    {
      Console.WriteLine("Isosceles Triangle!");
    }
    else if (newTriangle.Scalene)
    {
      Console.WriteLine("Scalene Triangle!");
    }
  }
}
