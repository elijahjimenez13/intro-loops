using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    int numA = 16;
    int numB = 40;
    
    // Euclid's algorithm
    while (numA != numB)
    {
    	if (numB > numA)
        {
        	numB = numB - numA;
        }
        else
        {
        	numA = numA - numB;
        }
    }
    
    Console.WriteLine("GCD is: " + numA);
    }
  }
}