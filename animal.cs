using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{
    //Base class for all mammals
    public class Mammal
    {
        private int _hunger=50;
        public int Hunger 
        {  
            get { return _hunger; }
            set { _hunger = value; }
        }
        public void Feed()
        {
            _hunger -= 25;
			if (_hunger < 0) _hunger = 0;
			else if (_hunger > 100) _hunger = 100;
        }
    }
    
    //The cat class inherits from the mammal
    public class Cat : Mammal
    {
        public string Sound { get; } = "Meow";
		
		//Property indicating if the cat is alive every time its called
        public bool Alive
        {
            get
            {
				//Create a pseudo-random number generator
               var rnd = new Random();
               if (rnd.Next(0, 9) > 4) return true;
               return false;
            }
        }
    }

    public static class Program
    {
        public static void Main() 
        {
           var cat = new Cat();
           var alive = cat.Alive;
           Console.WriteLine("Alive: {0}", alive);
           if (alive)
           {
               cat.Feed();
               Console.WriteLine("Hunger: {0}%", cat.Hunger);
           }
           Console.Read();
        }
    }
}