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
			{ 1,2,3,4,5,6,7,8,9,10,11 };
			
			var filtered = nlist.Where(x => x > 3 && x < 9);
			foreach (var item in filtered)
			{
				Console.WriteLine(item);
			}
        }
    }
}