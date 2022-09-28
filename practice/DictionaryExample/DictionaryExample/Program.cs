using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone_numbers = new Dictionary<string, int>();

            phone_numbers.Add("bhavneet", 1);
            phone_numbers.Add("tanvi", 2);


            var price_map = JsonConvert.DeserializeObject<Dictionary<string, double>>(File.ReadAllText("data1.json"));


            Console.WriteLine(price_map["Banana"]);

            Console.WriteLine("Hello World!");
        }
    }
}
