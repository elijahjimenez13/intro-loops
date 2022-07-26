using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int sum;
    int[] val = {2, 4, 1, -1};
    int i = 0;
    
    sum = 0;
    
    while (val[i] > -1)
    {
    	sum = sum + val[i];
        i++;
    }
    
    Console.WriteLine(sum);
    }
  }
}