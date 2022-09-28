using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace WeatherReport
{
    public class WeatherObtainer
    {
        private IWebHelper web_helper_dependency;

        public WeatherObtainer(IWebHelper webHelper)
        {
            web_helper_dependency = webHelper;
        }

        public void GetTemperature(out float temp_min, out float temp_max)
        {
            string parameters = "weather?lat=30.913170&lon=75.849541&units=metric&appid=ba3724895e56a803ff5f1af460841b24";

            var response = web_helper_dependency.SendGetRequestToAPI(parameters);
            var responseString = web_helper_dependency.ResponseToString(response);

            temp_min = JsonConvert.DeserializeObject<dynamic>(responseString).main.temp_min;
            temp_max = JsonConvert.DeserializeObject<dynamic>(responseString).main.temp_max;
        }

        public void decideClothes(float temp_min, float temp_max)
        {
            //Console.WriteLine(temp_min);
            //Console.WriteLine(temp_max);
        }


    }
}
