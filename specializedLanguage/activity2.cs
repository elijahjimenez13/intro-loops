using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int sum = 0;
    int[] val = {2, 4, 9, -1};
    int num = 0;
    int avg;
    int i = 0;
    
    while (val[i] > -1)
    {
    	sum = sum + val[i];
        num = num + 1;
        i++;
    }
    
    avg = sum / num;
    Console.WriteLine(avg);
    }
  }
}