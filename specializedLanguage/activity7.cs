using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    int numKids = 2;
    int userNum = 1;
    
    while (userNum == 1)
    {
    	Console.WriteLine(numKids);
        numKids = numKids * 2;
    }
    }
  }
}