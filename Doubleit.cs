using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    string stringNumber = Console.ReadLine(); // returns string
    int yourNumber = int.Parse(stringNumber); // parse into number
    int yourDoubledNumber = yourNumber * 2;
    string stringDoubledNumber = yourDoubledNumber.ToString(); // turn back to string
    Console.WriteLine("I doubled your number for you: " + yourDoubledNumber);
  }
}