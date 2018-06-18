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
        
        public static void Main() 
        {
			var nlist = new List<int>()
			{ 1,5,3,4,5,6,2,8,55,-4, 7 };
			
			
			//Sort without linq
			Console.WriteLine("Ascending sort (no LINQ):");
			nlist.Sort((a, b) => a.CompareTo(b)); // ascending sort
			//Print each element in nlist sequentually
			foreach (var item in nlist)
			{
				Console.WriteLine(item);
			}
			
			Console.WriteLine("Descending sort (no LINQ):");
			nlist.Sort((a, b) => -1* a.CompareTo(b)); // descending sort
			foreach (var item in nlist)
			{
				Console.WriteLine(item);
			}
			
			
			//Sort with linq
			nlist = new List<int>()
			{ 1,5,3,4,5,6,2,8,55,-4, 7 };
			Console.WriteLine("Ascending sort (with LINQ):");
			var asc = nlist.OrderBy(i => i);
			foreach (var item in asc)
			{
				Console.WriteLine(item);
			}
			
			Console.WriteLine("Descending sort (with LINQ):");
			var desc = nlist.OrderByDescending(i => i);
			foreach (var item in desc)
			{
				Console.WriteLine(item);
			}
							
			Console.ReadLine();
        }
    }
}