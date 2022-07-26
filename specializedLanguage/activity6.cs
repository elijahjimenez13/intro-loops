using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    int yearsPerGen;
    int userYear = 1600;
    int curYear = 2020;
    int numAncestors = 2;
    
    while (curYear >= userYear)
    {
    	Console.WriteLine(curYear + ": " + numAncestors + " ancestors\n");
        
        // Each ancestor has two parents
        numAncestors = 2 * numAncestors;
        
        // Go back 1 generation
        curYear = curYear - 20;
    }
    }
  }
}