using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_Shell
{

    public static class Program 
    {
		
		public static async Task  DownloadData(string url)
		{
		   byte[] data;
           var filename=url.Split('/').Last(); //Get only the text after the last '/' symbol
           Console.WriteLine("Downloading data...");
           var startDt = DateTime.Now;
		   
		   //Download data from url.
		   //The WebClient will be automatically disposed after exiting the using block
           using (var client = new WebClient())
           {
			   //Using the await operator will run the download method in a separate thread/task
			   //and return the byte[]. 
			   //If you remove the await the data will still be downloaded but the the method will return a Task.
			   //Getings the Task's Result property will block the calling thread untill the data is downloaded.
               data = await client.DownloadDataTaskAsync(url);
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
           
		}
			
		
		//Note: The main function can't be async bacause it is the entry point
        public static void Main() 
        {
			DownloadData("http://ipv4.download.thinkbroadband.com/5MB.zip");
			Console.Read();
        }
    }
}