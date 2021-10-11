using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    
    double[] celsius = new double[7];
    double[] fahrenheit = new double [7];

    for(int i=0; i < 7; i++)
    {

    Console.WriteLine("Enter temperature in Celsius");
    celsius[i]=Convert.ToDouble(Console.ReadLine());

    fahrenheit[i] = (celsius[i] * 9/5) + 32;

    }

    Console.WriteLine("Temperature in Fahrenheit");
    
    Array.Reverse(fahrenheit);
    foreach (double i in fahrenheit)
    {
      Console.WriteLine(i);

    }
    double sum = fahrenheit.Sum();
    double average = sum/7;

    Console.WriteLine("Average weekly temperature is " +average +" degree Fahrenheit.");
  }
}