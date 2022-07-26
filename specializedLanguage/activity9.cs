using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    int valuesSum = 0;
    int numValues = 0;
    int[] currValue = {10, 1, 6, 3, 0};
    float averageValue;
    int i = 0;
    
    // Get values until 0 (or less)
    while (currValue[i] > 0)
    {
    	valuesSum = valuesSum + currValue[i];
        numValues = numValues + 1;
        i++;
    }
    
    averageValue = (float)(1.0f * valuesSum) / numValues;
    Console.WriteLine("Average: " + averageValue);
    }
  }
}