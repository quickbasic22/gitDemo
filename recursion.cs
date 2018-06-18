using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{
    public static class Program 
    {
         public static double factorial(int number)
         {
            if (number == 1)
               return 1;
            else
              return number * factorial(number - 1);
         }
        
        public static void Main() 
        {
           var res = factorial(10);
           Console.WriteLine(res);
        }
    }
}