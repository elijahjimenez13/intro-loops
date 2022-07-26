using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    int[] userChoice = {1, 1, 1, 1, 1, 1, 1, 1, 0};
    float celsiusValue = 0.0f;
    float fahrenheitValue = 0.0f;
    int i = 0;
    
    while (userChoice[i] == 1)
    {
    	fahrenheitValue = (celsiusValue * 9.0f/5.0f) + 32.0f;
        
        Console.WriteLine(celsiusValue + " C is " + fahrenheitValue + " F\n");
        celsiusValue = celsiusValue + 5.0f;
        i++;
    }
    
    Console.WriteLine("Goodbye");
    }
  }
}