using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    int userNum = 60;
    
    while (userNum > 0)
    {
    	Console.WriteLine("-");
        userNum = userNum - 10;
    }
    
    Console.WriteLine("\n");
    }
  }
}