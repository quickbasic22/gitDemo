using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
             int v = 20;//the number of spaces
        
        //20 = how much how much lines
        for(int i = 1; i <= 20; i++)
        {
            //loop to print spaces
            for(int j = 1; j < v; j++)
            {
                Console.Write(" ");
            }
            
            v = v-1;

            //loop to print stars
                for(int t = 1; t < i*2; t++)
                {
                  Console.Write("*");  
                }

            //create a new Line
                Console.WriteLine();
        }
        
            Console.ReadLine();
        }
    }
}

