using System;
using System.Collections.Generic;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var n in get_number2())
                Console.WriteLine(n);

            //foreach (var n in get_number())
            //    Console.WriteLine(n);
            return;

            var web_helper = new WebAPIHelper("https://api.openweathermap.org/", "data/2.5/");
            WeatherObtainer weather_obtainer = new WeatherObtainer(web_helper);

            weather_obtainer.GetTemperature(out float t_min, out float t_max);
            weather_obtainer.decideClothes(t_min, t_max);
        }


        static List<int> get_number2()
        {
            return new List<int>() { 1, 2, 3 };
        }

        static IEnumerable<int> get_number()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
