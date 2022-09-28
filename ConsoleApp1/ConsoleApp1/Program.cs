using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fancy_tash = new Tash();
           // var ref2 = new Tash();
            fancy_tash.pattay2 = new string[12];

            var pehla_patta = fancy_tash.pattay[0];
            //Tash.buniyadi_pattay[0] = "invalid patta";
            // fancy_tash.pattay = new string[56];
            //Tash.buniyadi_pattay = new string[10];

            Console.WriteLine("Sat Sri Akal! : " + fancy_tash.pattay[0]);
            Console.ReadKey();
        }
    }
}



