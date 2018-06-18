using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           var url = "http://ipv4.download.thinkbroadband.com/5MB.zip";
		   byte[] data;
           var filename=url.Split('/').Last(); //Get only the text after the last '/' symbol
           Console.WriteLine("Downloading data...");
           var startDt = DateTime.Now;
		   
		   //Download data from url.
		   //The WebClient will be automatically disposed after exiting the using block
           using (var client = new WebClient())
           {
               data = client.DownloadData(url);
           }
           
		   //Get total time for download
           var elapsedSec = DateTime.Now.Subtract(startDt).TotalSeconds;
		   
		   //Remove all non-number characters from string (get size in mb)
		   var numOnlyStr = Regex.Replace(filename, "[^0-9]", string.Empty);
           var sizeMb = int.Parse(numOnlyStr);
		   
		   //Get size the proper way - count the bytes.
		   var bytesCnt = data.Length;
		   var sizeMbViaDataSize = (bytesCnt / 1024f) / 1024f;
			
           Console.WriteLine("Downloaded in {0} seconds", elapsedSec);
           Console.WriteLine("Average speed: {0} mb/s", sizeMb / elapsedSec);
           Console.Read();
        }
    }
}